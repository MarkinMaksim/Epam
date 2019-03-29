using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET.S._2019.Markin._03.Tests
{
    [TestClass]
    public class GcdTests
    {
        [DataTestMethod]
        [DataRow(16, new int[] { 64, 48 })]
        [DataRow(3, new int[] { 111, 432, 96 })]
        [DataRow(1, new int[] { 661, 113, 13 })]
        public void Test_EvklidRecursion_Correct_Data(int expected, params int[] numbers)
        {
            //int expected = 16;
            TimeSpan time = new TimeSpan();
            Assert.AreEqual(expected, GCD.GCDEvklid(out time, numbers));
        }
        
        [TestMethod]
        public void Test_EvklidRecursion_Null_Array()
        {
            
            TimeSpan time = new TimeSpan();
            Assert.ThrowsException<ArgumentNullException>(() => GCD.GCDEvklid(out time, null));
        }

        [TestMethod]
        public void Test_EvklidRecursion_Array_Length_Less_Than_1()
        {

            TimeSpan time = new TimeSpan();
            Assert.ThrowsException<ArgumentException>(() => GCD.GCDEvklid(out time, new int[] { }));
        }

        [DataTestMethod]
        [DataRow(16, new int[] { 64, 48 })]
        [DataRow(3, new int[] { 111, 432, 96 })]
        [DataRow(1, new int[] { 661, 113, 13 })]
        public void Test_SteinRecursion_Correct_Data(int expected, params int[] numbers)
        {
            //int expected = 16;
            TimeSpan time = new TimeSpan();
            Assert.AreEqual(expected, GCD.GCDStein(out time, numbers));
        }

        [TestMethod]
        public void Test_SteinRecursion_Null_Array()
        {

            TimeSpan time = new TimeSpan();
            Assert.ThrowsException<ArgumentNullException>(() => GCD.GCDStein(out time, null));
        }

        [TestMethod]
        public void Test_SteinRecursion_Array_Length_Less_Than_1()
        {

            TimeSpan time = new TimeSpan();
            Assert.ThrowsException<ArgumentException>(() => GCD.GCDStein(out time, new int[] { }));
        }


    }
}
