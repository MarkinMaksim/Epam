using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._12.Fibonachi
{
    public static class GenerateFibonachi
    {

        public static string GetFibonschi(int max)
        {
            string result = "Fibonachi: 0 1 1";
            long value1 = 1, value2 = 1;
            long sum = 0;

            for(int i = 0; i < max; i++)
            {
                sum = value1 + value2;
                result = result + " " + sum.ToString();
                value1 = value2;
                value2 = sum;
            }

            return result;
        }
    }
}
