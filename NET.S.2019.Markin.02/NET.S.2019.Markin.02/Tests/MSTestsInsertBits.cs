using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET.S._2019.Markin._02.Tests
{
    [TestClass]
    public class MSTestsInsertBits
    {
        [DataTestMethod]
        [DataRow(8, 15, 0, 0, 9)]
        [DataRow(15, 15, 0, 0, 15)]
        [DataRow(8, 15, 3, 8, 120)]
        [DataRow(15, 8, 3, 8, 79)]
        public void Test_InsertBits(int source, int insert, int start, int end, int expected)
        {
            int actual = InsertBits.InsertNumber(source, insert, start, end); 

            Assert.AreEqual(expected, actual);
        }


        [DataTestMethod]
        [DataRow(8, 15, -1, 0)]
        [DataRow(15, 15, -2, -1)]
        [DataRow(8, 15, 32, 33)]
        [DataRow(15, 8, 0, 32)]
        public void Test_InsertBits_Out_Of_Range(int source, int insert, int start, int end)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => InsertBits.InsertNumber(source, insert, start, end));
        }
    }
}
