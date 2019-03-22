using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NET.S._2019.Markin._02.Tests.Nunit
{
    [TestFixture]
    public class FilterDigits
    {
        [Test]
        public void Test_Filter_Not_Null()
        {
            int[] arr = { 1, 2, 7, 5, 77, 47, 45, 56, 97, 107 };
            IEnumerable<int> actual = FilterDigit.ByDigit(arr, 7);

            CollectionAssert.AreEqual(new int[] { 7, 77, 47, 97, 107 }, actual);
                
        }

        [Test]
        public void Test_Filter_Not_Null_2()
        {
            int[] arr = { 1, 2, 7, 5, 77, 47, 45, 56, 97, 105 };
            IEnumerable<int> actual = FilterDigit.ByDigit(arr, 5);

            CollectionAssert.AreEqual(new int[] { 5, 45, 56, 105 }, actual);

        }

        [Test]
        public void Test_Filter_Not_Null_3()
        {
            int[] arr = { 1, 2, 7, 5, 77, 47, 45, 56, 97, 107 };
            IEnumerable<int> actual = FilterDigit.ByDigit(arr, 4);

            CollectionAssert.AreEqual(new int[] { 47, 45}, actual);

        }

        [Test]
        public void Test_Filter_Is_Null()
        {

            Assert.Throws<ArgumentNullException>(() => FilterDigit.ByDigit(null, 7));
            

        }
    }
}
