using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._02
{
    public static class FindNthRoot
    {
        /// <summary>
        /// Returns the Root of n degree by Newton's method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="powerRoot"></param>
        /// <param name="eps"></param>
        /// <returns></returns>
        public static double FindRoot(double number, int powerRoot, double eps)
        {
            if (powerRoot < 1)
                throw new ArgumentOutOfRangeException(nameof(powerRoot) + "cantn't be less 1");
            if (eps <= 0)
                throw new ArgumentOutOfRangeException(nameof(eps) + "cantn't be less zero");

            double x0 = number / powerRoot;
            double x1 = (1.0 / powerRoot) * (((powerRoot - 1) * x0) + (number / Pow(x0, powerRoot - 1)));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1.0 / powerRoot) * (((powerRoot - 1) * x0 )+ (number/ Pow(x0, powerRoot - 1)));
            }

            return x1;
        }

        private static double Pow(double number, int power)
        {
            double result = number;
            for(int i = 1; i<power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
