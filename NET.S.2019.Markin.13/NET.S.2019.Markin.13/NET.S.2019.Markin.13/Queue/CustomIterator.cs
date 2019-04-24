using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._13
{
    internal class CustomIterator<T> : IEnumerator<T>
    {
        private T[] values;
        int pointer = -1;

        public CustomIterator(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            values = array;
        }

        public T Current
        {
            get
            {
                if (pointer != -1)
                {
                    return values[pointer];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get { return (object)Current; }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (pointer < (values.Length -1))
            {
                pointer++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            pointer = -1;
        }
    }
}
