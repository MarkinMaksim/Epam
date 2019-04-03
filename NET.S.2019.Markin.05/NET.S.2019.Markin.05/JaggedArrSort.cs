using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._05
{
    public static class JaggedArrSort
    {
        private delegate bool SortType(int[] arr1, int[] arr2);
            
        /// <summary>
        /// Check input array
        /// </summary>
        /// <param name="arr"></param>
        private static void Check(int[][] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));
            if (arr.Length == 0)
                throw new ArgumentException(nameof(arr));
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == null)
                    throw new ArgumentException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool SumInc(int[] arr1, int[] arr2)
        {
            if (arr1.Sum() > arr2.Sum())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool SumDec(int[] arr1, int[] arr2)
        {
            if (arr1.Sum() < arr2.Sum())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool MaxInc(int[] arr1, int[] arr2)
        {
            if (arr1.Max() > arr2.Max())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool MaxDec(int[] arr1, int[] arr2)
        {
            if (arr1.Max() < arr2.Max())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool MinInc(int[] arr1, int[] arr2)
        {
            if (arr1.Min() > arr2.Min())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private static bool MinDec(int[] arr1, int[] arr2)
        {
            if (arr1.Min() > arr2.Min())
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortByMaxInc(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = MaxInc;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortByMaxDec(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = MaxDec;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortBySumInc(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = SumInc;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortBySumDec(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = SumDec;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortByMinInc(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = MinInc;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jaggedArr"></param>
        public static void SortByMinDec(int[][] jaggedArr)
        {
            Check(jaggedArr);
            SortType sorttype = MinDec;
            Sort(jaggedArr, sorttype);
        }

        /// <summary>
        /// Sort jagged array
        /// </summary>
        /// <param name="jaggedArr"></param>
        /// <param name="sortType"></param>
        private static void Sort(int[][] jaggedArr, SortType sortType)
        {
            int[] tempArr;
            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArr.GetLength(0) - 1 - i; j++)
                {
                    if (sortType(jaggedArr[j], jaggedArr[j + 1]))
                    {
                        tempArr = jaggedArr[j];
                        jaggedArr[j] = jaggedArr[j + 1];
                        jaggedArr[j + 1] = tempArr;
                    }
                }
            }
        }
    }
}
