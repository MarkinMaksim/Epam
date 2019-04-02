using System;
using NUnit.Framework;

namespace NET.S._2019.Markin._05.Tests
{
    [TestFixture]
    public class JaggedArrayTests
    {
        [TestCase]
        public void Test_JaggedArray_BySum_Increment()
        {
            int[][] actual = new int[5][] { new int[] { 1, 1, 1 },
                                           new int[] { 1, 8, 3 },
                                           new int[] { 3, 4, 4 },
                                           new int[] { 4, 0, 6 },
                                           new int[] { 10, 12, 15 } };
            int[][] expected = new int[5][] { new int[] { 1, 1, 1 },
                                           new int[] {  4, 0, 6 },
                                           new int[] { 3, 4, 4 },
                                           new int[] {  1, 8, 3},
                                           new int[] { 10, 12, 15 }};
            JaggedArrSort.SortBySumInc(actual);
            Assert.AreEqual(expected, actual);
            
        }

        [TestCase]
        public void Test_JaggedArray_BySum_Decrement()
        {
            int[][] actual = new int[5][] { new int[] { 1, 1, 1 },
                                           new int[] { 1, 8, 3 },
                                           new int[] { 3, 4, 4 },
                                           new int[] { 4, 0, 6 },
                                           new int[] { 10, 12, 15 } };
            int[][] expected = new int[5][] { new int[] { 10, 12, 15},
                                           new int[] {  1, 8, 3  },
                                           new int[] { 3, 4, 4 },
                                           new int[] {  4, 0, 6},
                                           new int[] { 1, 1, 1 } };
            JaggedArrSort.SortBySumDec(actual);
            Assert.AreEqual(expected, actual);

        }
    }
}
