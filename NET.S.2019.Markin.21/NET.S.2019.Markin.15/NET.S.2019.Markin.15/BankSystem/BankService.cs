using System;
using System.Collections.Generic;
using NET.S._2019.Markin._08.BankSystem.Accounts;
using System.Text;

namespace NET.S._2019.Markin._08.BankSystem
{
    public class BankService
    {
        /// <summary>
        /// 
        /// </summary>
        public enum AccType
        {
            Basic,
            Gold,
            Platinum
        }

        public void CreateNewAcc(AccType acctype, string name, string lastname)
        {
            if (name == null || lastname == null)
            {
                throw new ArgumentNullException("Parametrs can't be null");
            }

            if (name.Length <= 1 || lastname.Length <= 1)
            {
                throw new ArgumentNullException("Parametrs can't be empty or less then 1");
            }

            switch (acctype)
            {
                case AccType.Basic:
                    AccountStorage.Add(new BaseAccount(name, lastname));
                    break;
                case AccType.Gold:
                    AccountStorage.Add(new GoldAccount(name, lastname));
                    break;
                case AccType.Platinum:
                    AccountStorage.Add(new PlatinumAccount(name, lastname));
                    break;
            }
        }

        public static void CheckId(string id)
        {
            if (id == null)
            {
                throw new ArgumentException();
            }

            if (Int32.Parse(id) < 1000000  || Int32.Parse(id) > 10000000)
            {
                throw new ArgumentException("id must be less than 1000000 and more than 10000000");
            }
        }

        public void Delete(string id)
        {
            CheckId(id);
            AccountStorage.Remove(id);
        }

        public void Deposit(string id, int amount)
        {
            CheckId(id);
            AccountStorage.GetByID(id).Deposit(amount);
        }

        public void Withdraw(string id, int amount)
        {
            CheckId(id);
            AccountStorage.GetByID(id).Withdraw(amount);
        }

        public void Save(string filename)
        {
            AccountStorage.SaveAccs(filename);
        }

        public void Load(string filename)
        {
            AccountStorage.LoadAccs(filename);
        }
    }
}
