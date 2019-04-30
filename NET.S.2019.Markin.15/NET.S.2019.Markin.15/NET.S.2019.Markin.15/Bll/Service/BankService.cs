using System;
using System.Collections.Generic;
using NET.S._2019.Markin._15.DAL.Interface;
using System.Text;

namespace NET.S._2019.Markin._15.Bll.Service
{
    public class BankService
    {

        private IStorage storage;
        /// <summary>
        /// 
        /// </summary>
        public enum AccType
        {
            Basic,
            Gold,
            Platinum
        }

        public BankService(IStorage storage)
        {
            if (storage == null)
            {
                throw new ArgumentNullException();
            }

            this.storage = storage;
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

            storage.Add(acctype.ToString(), name, lastname);
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
            storage.Remove(id);
        }

        public void Deposit(string id, int amount)
        {
            CheckId(id);
            storage.GetByID(id).Deposit(amount);
        }

        public void Withdraw(string id, int amount)
        {
            CheckId(id);
            storage.GetByID(id).Withdraw(amount);
        }

        public void Save(string filename)
        {
            storage.SaveAccs(filename);
        }

        public void Load(string filename)
        {
            storage.LoadAccs(filename);
        }
    }
}
