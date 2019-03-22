using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._02
{
    public static class InsertBits
    {   
        /// <summary>
        /// Bits of the second number inserted in positions
        /// from bits start by bits end
        /// </summary>
        /// <param name="numberSource"></param>
        /// <param name="numberIn"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int InsertNumber(int numberSource, int numberIn, int start, int end)
        {
            if (end < start)
                throw new ArgumentException("Start couldn't be more than end");
            if (start < 0 || start > 31 || end < 0 || end > 31)
                throw new ArgumentOutOfRangeException("Start and end must be more than 0 and less than 31");

            int j = 0;
            for(int i = start; i <= end; i++)
            {
                if((numberIn & (1 << j)) != 0)
                {
                    numberSource = numberSource | (1 << i);
                }
                j++;
            }
            return numberSource;

        }

    }
}
