using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if VALUE_IS_DOUBLE
	using ValueType = System.Double;
#else
#if VALUE_IS_SHORT
	using ValueType = System.Int16;
#else
#if VALUE_IS_LONG
	using ValueType = System.Int64;
#else
using ValueType = System.Int32;
#endif
#endif
#endif

namespace SortTest
{
    class StudSort
    {
        public static ValueType[] Sort(ValueType[] data)
        {
            int n = data.Length;
            for (int i = n / 2 - 1; i >= 0; i--)Heapify(data, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref data[0], ref data[i]);
                Heapify(data, i, 0);
            }

            return data;
        }

        static void Heapify(ValueType[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left].CompareTo(arr[largest]) > 0)
                largest = left;

            if (right < n && arr[right].CompareTo(arr[largest]) > 0)
                largest = right;

            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);
                Heapify(arr, n, largest);
            }
        }

        static void Swap(ref ValueType e1, ref ValueType e2)
        {
            ValueType temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
