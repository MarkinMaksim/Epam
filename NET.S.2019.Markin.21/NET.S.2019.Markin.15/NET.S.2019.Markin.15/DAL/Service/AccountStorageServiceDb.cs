using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._15.DAL.Entity;
using NET.S._2019.Markin._15.DAL.Interface;
using NET.S._2019.Markin._15.DAL.DbService;

namespace NET.S._2019.Markin._15.DAL.Service
{
    public class AccountStorageServiceDb : IStorage
    {
        public void Add(string accType, string name, string lastname)
        {
            using (AcountStorageDB db = new AcountStorageDB())
            {
                Account acc = new BaseAccount(name, lastname);
                switch (accType)
                {
                    case "Basic":
                        acc = new BaseAccount(name, lastname);
                        break;
                    case "Gold":
                        acc = new GoldAccount(name, lastname);
                        break;
                    case "Platinum":
                        acc = new PlatinumAccount(name, lastname);
                        break;
                }
                AcountModel acount = new AcountModel();
                acount.accid = acc.AccId;
                acount.ownerName = acc.OwnerName;
                acount.ownerLastname = acc.OwnerLastName;
                acount.balance = acc.Balance;
                acount.bonusPoints = acc.BonusPoints;
                acount.acouintType = accType;
            }
        }

        public List<Account> GetAccounts()
        {
            using (AcountStorageDB db = new AcountStorageDB())
            {
                List<AcountModel> tempacc = db.Acounts.ToList();

                if (tempacc != null)
                {
                    List<Account> listaccs = new List<Account>();

                    foreach (AcountModel acc in tempacc)
                    {
                        Account accentity;
                        switch (acc.acouintType)
                        {
                            case "Basic":
                                accentity = new BaseAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                                break;
                            case "Gold":
                                accentity = new GoldAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                                break;
                            case "Platinum":
                                accentity = new PlatinumAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                                break;
                            default:
                                accentity = new BaseAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                                break;

                        }

                        accentity.BonusPoints = acc.bonusPoints;
                        accentity.Balance = acc.balance;
                        listaccs.Add(accentity);
                    }

                    return listaccs;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public Account GetByID(string id)
        {
            using (AcountStorageDB db = new AcountStorageDB())
            {
                AcountModel acc = db.Acounts.SingleOrDefault(t => t.accid == id);
                if (acc != null)
                {
                    Account accentity;
                    switch (acc.acouintType)
                    {
                        case "Basic":
                            accentity = new BaseAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                            break;
                        case "Gold":
                            accentity = new GoldAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                            break;
                        case "Platinum":
                            accentity = new PlatinumAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                            break;
                        default:
                            accentity = new BaseAccount(acc.ownerName, acc.ownerLastname, acc.accid);
                            break;

                    }

                    accentity.BonusPoints = acc.bonusPoints;
                    accentity.Balance = acc.balance;

                    return accentity;
                }
                else
                {
                    throw new ArgumentException("There are no Account with such id:"+id);
                }

            }
        }

        public void LoadAccs(string filename)
        {
            // no sense
        }

        public void Remove(string id)
        {
            using (AcountStorageDB db = new AcountStorageDB())
            {
                AcountModel acc = db.Acounts.SingleOrDefault(t => t.accid == id);

                if (acc != null)
                {
                    db.Acounts.Remove(acc);
                    db.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("There are no Account with such id:" + id);
                }
            }
        }

        public void SaveAccs(string filename)
        {
            // no sense
        }
    }
}
