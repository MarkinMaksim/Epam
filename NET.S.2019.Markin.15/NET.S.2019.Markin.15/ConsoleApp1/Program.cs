using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._15.DAL.Service;
using NET.S._2019.Markin._15.DAL.Interface;
using NET.S._2019.Markin._15.DAL.Entity;
using NET.S._2019.Markin._15.Bll.Service;
using NET.S._2019.Markin._15.Bll.Interface;
using NET.S._2019.Markin._15.Bll.Entity;
using NET.S._2019.Markin._15;
using Ninject;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel conf = new StandardKernel();
            conf.Resolver();

            //IStorage storage = conf.Get<IStorage>();
            IService service = conf.Get<IService>();

            service.CreateNewAcc(AccType.Basic, "Maxim", "Markin");
            service.CreateNewAcc(AccType.Gold, "Maxim", "Markin");
            service.CreateNewAcc(AccType.Platinum, "Maxim", "Markin");

            service.Deposit("1000000", 1000);
            service.Deposit("1000001", 2000);
            service.Deposit("1000002", 3000);

            foreach(Account acc in service.GetAccounts())
            {
                Console.WriteLine(acc);
            }

            Console.ReadLine();

            service.Withdraw("1000000", 100);
            service.Withdraw("1000001", 200);
            service.Withdraw("1000002", 300);

            foreach (Account acc in service.GetAccounts())
            {
                Console.WriteLine(acc);
            }

            Console.ReadLine();
        }
    }
}
