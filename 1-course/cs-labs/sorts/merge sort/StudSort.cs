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
            if (data.Length <= 1)
                return data;

            int middle = data.Length / 2;
            ValueType[] left = new ValueType[middle];
            ValueType[] right = new ValueType[data.Length - middle];

            Array.Copy(data, 0, left, 0, middle);
            Array.Copy(data, middle, right, 0, data.Length - middle);

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        static ValueType[] Merge(ValueType[] left, ValueType[] right)
        {
            ValueType[] result = new ValueType[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }

            return result;
        }
    }
}
