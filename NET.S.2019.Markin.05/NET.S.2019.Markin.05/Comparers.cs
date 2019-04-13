using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._05
{
    public class Comparers 
    {
        public class CompareSumInc : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr1.Sum() > arr2.Sum())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public class CompareSumDec : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr2.Sum() > arr1.Sum())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public class CompareMaxInc : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr1.Max() > arr2.Max())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public class CompareMaxDec : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr2.Max() > arr1.Max())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public class CompareMinInc : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr1.Min() > arr2.Min())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public class CompareMinDec : IComparer<int[]>
        {
            public int Compare(int[] arr1, int[] arr2)
            {
                if (arr2.Min() > arr1.Min())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
