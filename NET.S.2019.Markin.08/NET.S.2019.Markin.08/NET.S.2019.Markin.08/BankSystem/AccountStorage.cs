using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using NET.S._2019.Markin._08.BankSystem.Accounts;

namespace NET.S._2019.Markin._08.BankSystem
{
    public class AccountStorage
    {
        private static List<Account> listaccs = new List<Account>();

        public static void Add(Account acc)
        {
            listaccs.Add(acc);
        }

        public static void Remove(string id)
        {
            Account acc = GetByID(id);

            if (acc == null)
            {
                throw new ArgumentException("Account not exist");
            }

            listaccs.Remove(acc);
        }

        public void SaveAccs(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("acc.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listaccs);

                Console.WriteLine("Объект сериализован");
            }
        }

        public void LoadAccs(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                List<Account> listnew = (List<Account>)formatter.Deserialize(fs);

                listaccs = listnew;
            }
        }

        private static Account GetByID(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            if (id == string.Empty)
            {
                throw new ArgumentException();
            }

            if (listaccs.Count == 0)
            {
                return null;
            }

            foreach (Account a in listaccs)
            {
                if (a.AccId == id)
                {
                    return a;
                }
            }

            return null;
        }
    }
}