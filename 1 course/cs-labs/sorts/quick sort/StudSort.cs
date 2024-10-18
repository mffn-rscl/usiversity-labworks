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
        private static int partition(ValueType[] data, int from, int to)
        {
            ValueType pivot = data[(from + to) / 2];
            int i = from - 1;
            int j = to + 1;
            while (true)
            {
                do {i++;} while (data[i] < pivot);

                do {j--;} while (data[j] > pivot);

                if (i >= j) return j;

                ValueType temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }
        
        private static void quick_sort(ValueType[] data, int from, int to)
        {
            if (from < to)
            {
                int mid = partition(data, from, to);
                quick_sort(data, from, mid);
                quick_sort(data, mid + 1, to);
            }
        }

        public static ValueType[] Sort(ValueType[] data)
        {
            quick_sort(data, 0, data.Length - 1);
            return data;
        }
    }
}