﻿using System;

namespace ArraySort
{
    /// <summary>
    /// Class that used for quick sort of array
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// Recursive function of quick sort
        /// </summary>
        /// <param name="arr">Array of int numbers</param>
        /// <param name="start">First index of array</param>
        /// <param name="end">Last index of array</param>
        /// <returns>Sorted array</returns>
        public int[] Sort(int[] arr, int start, int end)
        {
            if (arr == null)
                throw new ArgumentNullException("Array mustn't be null");
            if (start < 0 ||  end < 0 )
                throw new ArgumentException("Start and end parametrs must be more then zero and less then intMaxValue");
            if(start > arr.Length || start > arr.Length )
                throw new ArgumentException("Start and end parametrs must be in range of array lenght");
            if (arr.Length <= 1)
                return arr;

            //pi is partitionindex
            int pi;
            if (start < end)
            {
                pi = Partition(arr, start, end);
                Sort(arr, start, pi - 1);
                Sort(arr, pi + 1, end);
            }
            return arr;
        }

        /// <summary>
        /// This function takes last element as pivot, places
        /// the pivot element at its correct position in sorted
        /// array, and places all smaller(smaller than pivot)
        /// to left of pivot and all greater elements to right
        /// of pivot
        /// </summary>
        /// <param name="arr">Array of integers or subset of array</param>
        /// <param name="start">First index of array</param>
        /// <param name="end">Last index of array</param>
        /// <returns></returns>
        private int Partition(int[] arr, int start, int end)
        {
            int lastElement = arr[end];
            int pi = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= lastElement)
                {
                    pi++;
                    Swap(arr, pi, j);
                }
            }

            Swap(arr, pi + 1, end);
            return pi + 1;
        }

        private void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
