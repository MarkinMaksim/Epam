using System;
using NUnit.Framework;
using ArraySort;

namespace Tests
{
    public class TestsSort
    {
     
        [Test]
        public void Test_Quick_sort_Array_Not_Null()
        {
            int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            QuickSort sort = new QuickSort();
            int[] actual = sort.Sort(arr, 0, arr.Length - 1);
            int[] expected = new int[] { 1, 2, 4, 5, 8, 11, 16, 20, 90, 98 };
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Quick_sort_Array_Is_Empty()
        {
            int[] arr = new int[] { };
            QuickSort qsort = new QuickSort();
            int[] actual = qsort.Sort(arr, 0, arr.Length);
            int[] expected = arr;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Quick_sort_Array_Contains_One_Element()
        {
            int[] arr = new int[] { 1 };
            QuickSort qsort = new QuickSort();
            int[] actual = qsort.Sort(arr, 0, arr.Length);
            int[] expected = arr;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Quick_sort_Start_Index_Less_zero()
        {
            int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            QuickSort qsort = new QuickSort();
            Assert.That(() => qsort.Sort(arr, -1, arr.Length - 1), Throws.TypeOf<ArgumentException>());
        }



        [Test]
        public void Test_Quick_sort_End_Index_Less_zero()
        {
            int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            QuickSort qsort = new QuickSort();
            Assert.That(() => qsort.Sort(arr, 0, -1), Throws.TypeOf<ArgumentException>());
             
        }

        [Test]
        public void Test_Quick_Array_Is_Null()
        {
            QuickSort qsort = new QuickSort();
            Assert.Throws<ArgumentNullException>(() => qsort.Sort(null,0, 1));

        }

        [Test]
        public void Test_Merge_Sort_Array_Not_Null()
        {
            int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            MergeSort mergeSort = new MergeSort();
            int[] actual = mergeSort.Sort(arr);
            int[] expected = new int[] { 1, 2, 4, 5, 8, 11, 16, 20, 90, 98 };
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Merge_Sort_Array_Is_Null()
        {
            int[] arr = null;
            MergeSort mergeSort = new MergeSort();
            Assert.Throws<ArgumentNullException>(() => mergeSort.Sort(null));
        }


    }
}