using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._12.Roullete
{
    public class Player
    {
        private string name;
        private int number;

        public Player(string name)
        {
            this.name = name ?? throw new ArgumentNullException();
        }

        public void Check(Roullete roullete)
        {
            if (roullete == null)
            {
                throw new ArgumentNullException(nameof(roullete) + "can't be null");
            }
        }
        public void OnOdd(Roullete roullete)
        {
            Check(roullete);
            roullete.OddNumber += ShowMessage;
            roullete.EvenNumber -= ShowMessage;
        }

        public void OnEven(Roullete roullete)
        {
            Check(roullete);
            roullete.EvenNumber += ShowMessage;
            roullete.OddNumber -= ShowMessage;
        }

        public void OnRed(Roullete roullete)
        {
            Check(roullete);
            roullete.RedNumber += ShowMessage;
            roullete.BlackNumber -= ShowMessage;
        }

        public void OnBlack(Roullete roullete)
        {
            Check(roullete);
            roullete.BlackNumber += ShowMessage;
            roullete.RedNumber -= ShowMessage;
        }

        public void OnNumber(Roullete roullete, int value)
        {
            Check(roullete);

            if (value < 0 || value > 36)
            {
                throw new ArgumentException(nameof(roullete) + "can't be less than 0 and more than 36");
            }

            this.number = value;
            roullete.OnNumber += ShowMessageOnNumber;
        }

        public void ShowMessage(object sender, EventArgs e)
        {
            Console.WriteLine("You won:" + name);
        }

        public void ShowMessageOnNumber(object sender, RoulleteEventArgs e)
        {
            if (number == e.Number)
            {
                Console.WriteLine("You won:" + name);
            }
        }
    }
}
