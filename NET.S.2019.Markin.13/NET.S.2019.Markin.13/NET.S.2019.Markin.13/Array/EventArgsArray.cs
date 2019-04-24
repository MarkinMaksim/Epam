using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._13.Array
{
    public class EventArgsArray
    {
        private int i;
        private int j;

        public int I
        {
            get
            {
                return i;
            }
        }

        public int J
        {
            get
            {
                return j;
            }
        }

        public EventArgsArray(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
}
