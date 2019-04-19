using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._12.Roullete
{
    public class Roullete
    {
        public event EventHandler OddNumber;
        public event EventHandler EvenNumber;
        public event EventHandler RedNumber;
        public event EventHandler BlackNumber;
        public event EventHandler<RoulleteEventArgs> OnNumber;

        private enum Color
        {
            red,
            black
        }

        public void Spin()
        {
            Random rnd = new Random();
            //int result = rnd.Next(0, 36);
            int result = 9;
            Color color = (Color)rnd.Next(0,1);

            if (color == Color.red)
            {
                RedWins();
            }
            else
            {
                BlackWins();
            }

            if (result % 2 == 1)
            {
                OddWins();
            }
            else
            {
                EvenWins();
            }

            NumberWins(new RoulleteEventArgs(result));   
        }

        private void RedWins()
        {
            if (RedNumber != null)
            {
                RedNumber(this, new EventArgs());
            }
        }

        private void BlackWins()
        {
            if (BlackNumber != null)
            {
                BlackNumber(this, new EventArgs());
            }
        }

        private void OddWins()
        {
            if (OddNumber != null)
            {
                OddNumber(this, new EventArgs());
            }
        }

        private void EvenWins()
        {
            if (EvenNumber != null)
            {
                EvenNumber(this, new EventArgs());
            }
        }

        private void NumberWins(RoulleteEventArgs e)
        {
            if (OnNumber != null)
            {
                OnNumber(this, e);
            }
        }
    }
}
