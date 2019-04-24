using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._13.Array
{
    public class TransporyArray<T> : T<T>
    {
        public TransporyArray(int capasity) : base(capasity) { }

        public override void AddElement(int i, int j, T item)
        {
            if (values.GetLength(0) <= i || values.GetLength(1) <= j)
            {
                throw new ArgumentException();
            }

            values[i, j] = item;
            values[j, i] = item;
        }
    }
}
