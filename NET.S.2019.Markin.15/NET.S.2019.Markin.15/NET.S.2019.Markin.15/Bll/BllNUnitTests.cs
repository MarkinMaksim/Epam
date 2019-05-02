using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NET.S._2019.Markin._15.DAL.Service;
using NET.S._2019.Markin._15.DAL.Interface;
using NET.S._2019.Markin._15.DAL.Entity;
using NET.S._2019.Markin._15.Bll.Service;
using NET.S._2019.Markin._15.Bll.Interface;
using NET.S._2019.Markin._15.Bll.Entity;

namespace NET.S._2019.Markin._15.Bll
{
    [TestFixture]
    public class BllNUnitTests
    {
        [Test]
        public void Bll_CreateNew_Account()
        {
            IService service = new BankService(new AccountStorage());

            service.CreateNewAcc(AccType.Basic, "Maxim", "Markin");
            var actual = service.GetAccounts();
            int expected = 1;

            Assert.AreEqual(expected, actual.Count);
        }

        [Test]
        public void Bll_CreateNew_Wrong_Name_Account()
        {
            IService service = new BankService(new AccountStorage());

            Assert.Throws<ArgumentNullException>(() => service.CreateNewAcc(AccType.Basic, "", "Markin"));
        }

        [Test]
        public void Bll_CreateNew_Wrong_LastName_Account()
        {
            IService service = new BankService(new AccountStorage());

            Assert.Throws<ArgumentNullException>(() => service.CreateNewAcc(AccType.Basic, "Max", ""));
        }

        [Test]
        public void Bll_Delete_Account()
        {
            IService service = new BankService(new AccountStorage());

            service.CreateNewAcc(AccType.Basic, "Maxim", "Markin");
            service.Delete("1000000");
            var actual = service.GetAccounts();
            int expected = 0;

            Assert.AreEqual(expected, actual.Count);
        }

        [Test]
        public void Bll_Delete_Wrong_Id_Account()
        {
            IService service = new BankService(new AccountStorage());

            service.CreateNewAcc(AccType.Basic, "Maxim", "Markin");



            Assert.Throws<ArgumentException>(() => service.Delete("1000010"));
        }

    }
}
