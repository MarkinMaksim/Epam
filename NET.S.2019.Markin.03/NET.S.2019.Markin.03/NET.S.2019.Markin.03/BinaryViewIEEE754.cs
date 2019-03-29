using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._03
{
    public static class BinaryViewIEEE754
    {
        /// <summary>
        /// Converts double number to IEEE75
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetBinaryView(this double number)
        {
            string sign = number < 0 ? "1" : "0";
            switch (number)
            {
                case double.Epsilon:
                    return "0000000000000000000000000000000000000000000000000000000000000001";
                case double.NaN:
                    return "1111111111111000000000000000000000000000000000000000000000000000";
                case double.PositiveInfinity:
                    return "0111111111110000000000000000000000000000000000000000000000000000";
                case double.NegativeInfinity:
                    return "1111111111110000000000000000000000000000000000000000000000000000";
                case 0:
                    return $"{sign}000000000000000000000000000000000000000000000000000000000000000";
            }
            double temp = number;
            int power = 0;
            number = Math.Abs(number);
            double multipier;

            if (number >= 2)
                multipier = 0.5;
            else
                multipier = 2;

            for(power = 0; power >= 0; power++)
            {
                if (number >= 1 && number < 2)
                    break;
                number *= multipier;
            }

            if (temp < 1 && temp > -1)
                power *= -1;

            number--;
            
            string exponent = Convert.ToString(power + 1023, 2);
            while(exponent.Length < 11)
            {
                exponent = exponent.Insert(0, "0");
            }
            string mantisa = ConvertToBinary(number);
            string result = $"{sign}{exponent}{mantisa}";
            return result;

        }

        /// <summary>
        /// Convert decimal mantisa to binary form
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string ConvertToBinary(double number)
        {
            if (number > 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)}");
            }

            string integerPart;
            string result = string.Empty;

            for(int i = 0; i < 52; i++)
            {
                number *= 2;
                if (number >= 1)
                {
                    integerPart = "1";
                    number--;
                }
                else
                    integerPart = "0";
                result = $"{result}{integerPart}";
            }

            return result;
        }
    }
}
