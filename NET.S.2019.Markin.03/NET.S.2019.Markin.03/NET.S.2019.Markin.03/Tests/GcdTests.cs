using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET.S._2019.Markin._03.Tests
{
    [TestClass]
    public class GcdTests
    {
        [DataTestMethod]
        [DataRow(16, new int[] { 64, 48 })]
        [DataRow(3,new int[]{111, 432, 96})]
        [DataRow(1, new int[] { 661, 113, 13})]
        public void Test_EvklidRecursion_Correct_Data(int expected,params int[] numbers)
        {
            //int expected = 16;
            TimeSpan time = new TimeSpan();
            Assert.AreEqual(expected,GCD.GCDEvklid(out time, numbers));
        }

    }
}
