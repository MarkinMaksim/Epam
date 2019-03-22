using System;
using NUnit.Framework;

namespace NET.S._2019.Markin._02.Tests
{
    public class FindBiggerNumberWithTime
    {
        [TestCase(12)]
        [TestCase(513)]
        [TestCase(2017)]
        [TestCase(414)]
        [TestCase(144)]
        [TestCase(1234321)]
        [TestCase(1234126)]
        [TestCase(3456432)]
        [TestCase(10)]
        [TestCase(20)]
        public void Find(int number)
        {
            TimeSpan time = new TimeSpan();
            Numbers.FindNextBiggerWithTime(number, out time);
            Assert.That(time, Is.LessThan(new TimeSpan(0,0,1)));
        }
    }
}
