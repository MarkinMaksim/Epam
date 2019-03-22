using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    /// <summary>
    /// Class that sort array by Megre algorithm
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Subset array's on two part's
        /// </summary>
        /// <param name="array">Array or subset of integers</param>
        /// <returns>Sorted array</returns>
        public int[] Sort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Array shouldn't be null");
            if (array.Length == 1)
                return array;

            int[] left = new int[array.Length / 2];

            int[] right = new int[array.Length - left.Length];
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = array[left.Length + i];
            }
            return Merge(Sort(left),Sort(right));
        }

        /// <summary>
        /// Sort subsets by rules of Merge. After sort method conecting sorted arrays
        /// </summary>
        /// <param name="left">array of integers</param>
        /// <param name="right">array of integers</param>
        /// <returns>Sorted and conected array</returns>
        private int[] Merge(int[] left, int[] right)
        {
            int leftIndex = 0, rightIndex = 0;
            int[] merged = new int[left.Length + right.Length];
            for (int ResultarrIndex = 0; ResultarrIndex < left.Length + right.Length; ResultarrIndex++)
            {
                if (rightIndex < right.Length && leftIndex < left.Length)
                    if (left[leftIndex] > right[rightIndex])
                        merged[ResultarrIndex] = right[rightIndex++];
                    else 
                        merged[ResultarrIndex] = left[leftIndex++];
                else
                    if (rightIndex < right.Length)
                        merged[ResultarrIndex] = right[rightIndex++];
                    else
                        merged[ResultarrIndex] = left[leftIndex++];
            }
            return merged;
        }
    }
}
