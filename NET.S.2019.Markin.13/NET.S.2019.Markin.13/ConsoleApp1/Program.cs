using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._13;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomContainer<int> container = new CustomContainer<int>();
            container.Enqueue(5);
            container.Enqueue(8);
            container.Enqueue(9);
            container.Enqueue(10);
            foreach(int i in container)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
