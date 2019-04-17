using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._12.BinarySearch
{
    public static class BinarySearch
    {

        public static int Find<T>(IEnumerable<T> t, T value)
        {
            if (t == null || value == null)
            {
                throw new ArgumentNullException();
            }

            List<T> list = t.ToList();
            if (IsSorted(list,(value1,value2) => { return ((IComparable<T>)value2).CompareTo(value1);  } ))
            {
                return Search(list, (value1, value2) => { return ((IComparable<T>)value2).CompareTo(value1); }, value);
            }
            else
            {
                throw new ArgumentException("Not sorted. Please sort it");
            }
        }

        private static int Search<T>(IList<T> list, Comparison<T> comp, T value)
        {
            int left = 0, right = list.Count;
            int search = -1;

            while(left < right)
            {
                int middle = (left + right) / 2;

                if (comp(list[middle], value) == 0)
                {
                    search = middle;
                    break;
                }

                if (comp(list[middle], value) < 0)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return search;
        }

        private static bool IsSorted<T>(IList<T> t, Comparison<T> comp)
        {
           for(int i = 1; i < t.Count; i++)
           {
                if (comp(t[i-1], t[i]) < 0)
                {
                    return false;
                }
           }

            return true;
        }
    }
}
