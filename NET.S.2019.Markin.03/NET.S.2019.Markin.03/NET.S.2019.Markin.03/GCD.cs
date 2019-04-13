using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._03
{
    public static class GCD
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GCDEvklid(out TimeSpan time, params int[] numbers)
        {
            return GcdFind(out time, EvklidRecursion, numbers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        private static int EvklidRecursion(int val1, int val2)
        {
            if (val2 == 0)
            {
                return val1;
            }
            else
            {
                return EvklidRecursion(val2, val1 % val2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GCDStein(out TimeSpan time, params int[] numbers)
        {
            return GcdFind(out time, SteinRecursion, numbers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        private static int SteinRecursion(int val1, int val2)
        {
            if (val1 == val2)
            {
                return val1;
            }

            if (val1 == 0)
            {
                return val2;
            }

            if (val2 == 0)
            {
                return val1;
            }

            if ((~val1 & 1) != 0)
            {
                if ((val2 & 1) != 0)
                {
                    return SteinRecursion(val1 >> 1, val2);
                }
                else
                {
                    return SteinRecursion(val1 >> 1, val2 >> 1) << 1;
                }
            }

            if ((~val2 & 1) != 0)
            {
                return SteinRecursion(val1, val2 >> 1);
            }

            if (val1 > val2)
            {
                return SteinRecursion((val1 - val2) >> 1, val2);
            }

            return SteinRecursion((val2 - val1) >> 1, val1);
        }

        private static int GcdFind(out TimeSpan time, Func<int, int, int> func, params int[] numbers)
        {

            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers) + " can't be null");
            }

            if (numbers.Length == 1)
            {
                throw new ArgumentException(nameof(numbers) + " count of numbers must be more than 1");
            }

            Stopwatch timer = new Stopwatch();

            int res = numbers[0];

            timer.Start();

            for (int i = 1; i < numbers.Length; i++)
            {
                res = func(res, numbers[i]);
                //res = SteinRecursion(res, numbers[i]);
            }

            timer.Stop();

            time = timer.Elapsed;

            return res;
        }
    }
}
