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
            bool swapped;
            int start = 0;
            int end = data.Length - 1;

            do
            {
                swapped = false;

                for (int i = start; i < end; ++i)
                {
                    if (data[i].CompareTo(data[i + 1]) > 0)
                    {
                        Swap(ref data[i], ref data[i + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                end--;

                for (int i = end; i > start; --i)
                {
                    if (data[i].CompareTo(data[i - 1]) < 0)
                    {
                        Swap(ref data[i], ref data[i - 1]);
                        swapped = true;
                    }
                }

                start++;
            } while (swapped);

            return data;
        }

        static void Swap(ref ValueType e1, ref ValueType e2)
        {
            ValueType temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
