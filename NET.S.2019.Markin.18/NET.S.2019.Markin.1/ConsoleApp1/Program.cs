using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._18;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            URLTxtReader urls = new URLTxtReader("input.txt");
            URLSerialize.SaveXml(URLParser.Parse(urls.URLs), "result.txt");
        }
    }
}
