using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._02
{
    public static class Numbers
    {
        /// <summary>
        /// Return's next biger number, which consists digits of the input number
        /// </summary>
        /// <param name="number">int</param>
        /// <returns>next biger number</returns>
        public static int FindNextBigger(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number can't be less 0");

            int result = 0;
            string str = number.ToString();
            char[] charArray = str.ToCharArray();
            char temp;

            for (int indexSwap = charArray.Length - 1; indexSwap > 0; indexSwap--)
            {
                if (charArray[indexSwap] > charArray[indexSwap - 1])
                {
                    temp = charArray[indexSwap - 1];
                    charArray[indexSwap - 1] = charArray[indexSwap];
                    charArray[indexSwap] = temp;
                    // Sort right part after swap of elements
                    for (int x = indexSwap; x < charArray.Length; x++)
                    {
                        for (int y = x + 1; y < charArray.Length; y++)
                        {
                            if (charArray[x] > charArray[y])
                            {
                                temp = charArray[y];
                                charArray[y] = charArray[x];
                                charArray[x] = temp;
                            }
                        }
                    }
                    indexSwap = 0;
                }
            }
            str = new string(charArray);
            try
            {
                result = Convert.ToInt32(str);
            }
            catch (OverflowException)
            {
                return -1;
            }
            if (result == number)
                return -1;
            return result;
        }

        /// <summary>
        /// Return's next biger number, which consists digits of the input number
        /// Also you can check time that method take
        /// </summary>
        /// <param name="number">int</param>
        /// <param name="time">TimeSpan</param>
        /// <returns>int</returns>
        public static int FindNextBiggerWithTime(int number, out TimeSpan time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = FindNextBigger(number);
            timer.Stop();
            time = timer.Elapsed;
            return result;
        }
    }
}
