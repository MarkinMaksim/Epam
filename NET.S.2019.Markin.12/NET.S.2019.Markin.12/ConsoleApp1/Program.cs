using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._12.Roullete;
using NET.S._2019.Markin._12.Fibonachi;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Roullete roullete = new Roullete();
            Player p1 = new Player("Max");
            p1.OnNumber(roullete, 9);
            roullete.Spin();
            string result = GenerateFibonachi.GetFibonschi(5);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
