using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._02
{
    public static class FilterDigit
    {
        /// <summary>
        /// Take list of numbers and digit that we search in list
        /// </summary>
        /// <param name="list">List with numbers</param>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static IEnumerable<int> ByDigit(IEnumerable<int> list, int digit)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list) + " cann't be equal null!");
            if (digit < 0)
                digit = Math.Abs(digit);

            List<int> result = new List<int>();
            foreach(int number in list)
            {
                if (number.ToString().Contains(digit.ToString()))
                    result.Add(number);

            }
            return result;
        }
    }
}
