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

        /// <summary>
        /// Add accaunt to the list
        /// </summary>
        /// <param name="acc"></param>
        public static void Add(Account acc)
        {
            listaccs.Add(acc);
        }

        /// <summary>
        /// Delete account from list by id
        /// </summary>
        /// <param name="id"></param>
        public static void Remove(string id)
        {
            Account acc = GetByID(id);

            if (acc == null)
            {
                throw new ArgumentException("Account not exist");
            }

            listaccs.Remove(acc);
        }

        /// <summary>
        /// Save list of accounts in file
        /// </summary>
        /// <param name="filename"></param>
        public static void SaveAccs(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("acc.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listaccs);

                Console.WriteLine("Объект сериализован");
            }
        }

        /// <summary>
        /// Load list of accounts from file
        /// </summary>
        /// <param name="filename"></param>
        public static void LoadAccs(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                List<Account> listnew = (List<Account>)formatter.Deserialize(fs);

                listaccs = listnew;
            }
        }

        /// <summary>
        /// Found account in list by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Account GetByID(string id)
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