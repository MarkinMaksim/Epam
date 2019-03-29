using System;
using NUnit.Framework;


namespace NET.S._2019.Markin._02.Tests
{
    [TestFixture]
    public class InsertBits
    {
        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(15, 15, 0, 0, 15)]
        [TestCase(8, 15, 3, 8, 120)]
        [TestCase(15, 8, 3, 8, 79)]
        public void Test_InsertBits(int source, int insert, int start, int end, int expected)
        {
            int actual = _02.InsertBits.InsertNumber(source, insert, start, end);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 15, -1, 0)]
        [TestCase(15, 15, -2, -1)]
        [TestCase(8, 15, 32, 33)]
        [TestCase(15, 8, 0, 32)]
        public void Test_InsertBits_Out_Of_Range(int source, int insert, int start, int end)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _02.InsertBits.InsertNumber(source, insert, start, end));
        }

        [TestCase(8, 15, 5, 0)]
        [TestCase(15, 15, 15, 0)]
        [TestCase(8, 15, 16, 15)]
        [TestCase(15, 8, 20, 1)]
        public void Test_InsertBits_Start_More_End(int source, int insert, int start, int end)
        {
            Assert.Throws<ArgumentException>(() => _02.InsertBits.InsertNumber(source, insert, start, end));
        }
    }
}
