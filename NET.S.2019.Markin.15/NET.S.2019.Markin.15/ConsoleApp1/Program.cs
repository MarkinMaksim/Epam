using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._15.DAL.Service;
using NET.S._2019.Markin._15.Bll.Service;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountStorage storage = new AccountStorage();
            BankService service = new BankService(storage);
            service.CreateNewAcc(BankService.AccType.Basic, "Max", "Markin");
        }
    }
}
