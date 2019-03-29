using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._03
{
    public static class BinaryViewIEEE754
    {
        public static string GetBinaryView(this double number)
        {
            string sign = number < 0 ? "1" : "0";

            number = Math.Abs(number);

            string intPart = ConvertToBinaryInt((long)number);

            double real = number - (long)number;
            string realPart = ConvertToBinaryReal(real, 52 - intPart.Length - 1);

            string exponent = ConvertToBinaryInt(1023 + intPart.Length - 1);

            string mantisa = $"{intPart.Substring(1)}{realPart}".PadRight(52, '0');
            string result = $"{sign}{exponent}{mantisa}";
            return result;

        }

        private static string ConvertToBinaryInt(long number)
        {
            string result = string.Empty;

            if (number == 0)
                return "0";

            while(number > 0)
            {
                long mod = number % 2;
                number /= 2;
                result = $"{mod}{result}";
            }

            return result;
        }
        private static string ConvertToBinaryReal(double number, int exponent)
        {
            if(number > 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)}");
            }

            string result = string.Empty;

            for(int i = 0; i < exponent; i++)
            {
                number *= 2;
                var integerPart = (int)number;
                number -= integerPart;
                result = $"{result}{integerPart}";
            }

            return result;
        }
    }
}
