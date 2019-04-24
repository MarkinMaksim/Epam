using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._13.Array
{
    public static class ArrayExtension
    {
        public static T[,] Sum<T> (this Arrays<T> value, T[,] value2) where T : struct
        {
            if (value == null || value2 == null)
            {
                throw new ArgumentNullException();
            }

            if (value.Values.GetType() != value2.GetType())
            {
                throw new ArrayTypeMismatchException();
            }

            int smalli, smallj;
            T[,] result;

            if (value.Values.GetLength(0) > value2.GetLength(0))
            {
                result = value.Values.Clone() as T[,];
                smalli = value2.GetLength(0);
                smallj = value2.GetLength(1);
            }
            else
            {
                result = value2.Clone() as T[,];
                smalli = value.Values.GetLength(0);
                smallj = value.Values.GetLength(1);
            }

            for (int i = 0; i < smalli; i++)
            {
                for (int j = 0; j < smallj; j++)
                {
                    if (i < value2.GetLength(0) || j < value2.GetLength(1))
                    {
                        result[i, j] += (dynamic)value2[i, j];
                    }
                }
            }

            return result;
        }
    }
}
