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

        
        public static void SortInterface(int[][] jaggedArr, IComparer<int[]> comparer)
        {
            SortArray(jaggedArr, comparer.Compare);    
        }

        /// <summary>
        /// Sort jagged array
        /// </summary>
        /// <param name="jaggedArr"></param>
        /// <param name="sortType"></param>
        private static void SortArray(int[][] jaggedArr, Comparison<int[]> compare)
        {
            int[] tempArr;
            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArr.GetLength(0) - 1 - i; j++)
                {
                    if (compare(jaggedArr[j], jaggedArr[j + 1]) == 1)
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
