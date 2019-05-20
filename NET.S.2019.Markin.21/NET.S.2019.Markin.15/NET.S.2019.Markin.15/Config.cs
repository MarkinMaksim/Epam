using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NET.S._2019.Markin._15.DAL.Interface;
using NET.S._2019.Markin._15.DAL.Service;
using NET.S._2019.Markin._15.DAL.Entity;
using NET.S._2019.Markin._15.Bll.Interface;
using NET.S._2019.Markin._15.Bll.Service;

namespace NET.S._2019.Markin._15
{
    public static class Config  
    {
        public static void Resolver(this IKernel kernel)
        {
            kernel.Bind<IStorage>().To<AccountStorage>();
            kernel.Bind<IService>().To<BankService>();
            kernel.Bind<Account>().To<BaseAccount>();
            kernel.Bind<Account>().To<GoldAccount>();
            kernel.Bind<Account>().To<PlatinumAccount>();
        }
    }
}
