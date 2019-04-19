using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._12.Roullete
{
    public class RoulleteEventArgs
    {
        private int number;

        public int Number
        {
            get
            {
                return number;
            }
        }

        public RoulleteEventArgs(int number)
        {
            this.number = number;
        }
    }
}
