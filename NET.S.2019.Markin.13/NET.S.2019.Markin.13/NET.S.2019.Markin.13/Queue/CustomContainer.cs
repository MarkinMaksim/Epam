using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._13
{
    public class CustomContainer<T>: IEnumerable<T>
    {
        private T[] _array;
        private int size;
        private const int defaultCapacity = 10;
        private int capacity;
        private int head;
        private int tail;

        public CustomContainer()
        {
            capacity = defaultCapacity;
            this._array = new T[defaultCapacity];
            this.size = 0;
            this.head = -1;
            this.tail = 0;
        }

        public bool isEmpty() //проверка на пустоту
        {
            return size == 0;
        }

        public void Enqueue(T newElement)
        {
            if (this.size == this.capacity)
            {
                T[] newQueue = new T[2 * capacity];    
                Array.Copy(_array, 0, newQueue, 0, _array.Length);
                _array = newQueue;
                capacity *= 2;
            }
            size++;
            _array[tail++ % capacity] = newElement;
        }

        public T Dequeue()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            size--;
            return _array[++head % capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomIterator<T>(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CustomIterator<T>(_array);
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

    }
}
