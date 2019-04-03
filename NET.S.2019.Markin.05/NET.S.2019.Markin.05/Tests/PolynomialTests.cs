using System;
using NUnit.Framework;

namespace NET.S._2019.Markin._05.Tezts
{
    [TestFixture]
    public class PolynomialTests
    {
        [TestCase]
        public void Test_Polynomial_Sum()
        {
            Polynomial pol1 = new Polynomial(3, 8, 9);
            Polynomial pol2 = new Polynomial(7, 2, 1);
            Polynomial expected = new Polynomial(10, 10, 10);

            Polynomial actual = pol1 + pol2;
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Test_Polynomial_Sub()
        {
            Polynomial pol1 = new Polynomial(3, 8, 9);
            Polynomial pol2 = new Polynomial(7, 2, 1);
            Polynomial expected = new Polynomial(-4, 6, 8);

            Polynomial actual = pol1 - pol2;
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Test_Polynomial_Multiply()
        {
            Polynomial pol1 = new Polynomial(3, 8);
            Polynomial pol2 = new Polynomial(7, 2);
            Polynomial expected = new Polynomial(21,62,16);

            Polynomial actual = pol1 * pol2;
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Test_Polynomial_ToString()
        {
            Polynomial pol1 = new Polynomial(3, 8, 9);
            string expected = "9*x^2+8*x^1+3";

            string actual = pol1.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Test_Polynomial_Equals()
        {
            Polynomial pol1 = new Polynomial(3, 8, 9);
            Polynomial pol2 = new Polynomial(3, 8, 9);

            Assert.IsTrue(pol1 == pol2);
        }

    }
}
