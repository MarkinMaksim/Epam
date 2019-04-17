using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace NET.S._2019.Markin._12.BinarySearch.Tests
{
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void Test_Correct_Input()
        {
            int[] array = new int[] { 4, 8, 13, 15, 19, 26, 29, 35, 39, 47, 58, 69 };
            int actual = BinarySearch.Find(array, 8);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
