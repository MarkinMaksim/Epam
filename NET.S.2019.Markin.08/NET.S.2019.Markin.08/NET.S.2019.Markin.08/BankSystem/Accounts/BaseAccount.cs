﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2019.Markin._08.BankSystem.Accounts
{
    /// <summary>
    /// BaseAccount in bank system
    /// </summary>
    [Serializable]
    public class BaseAccount : Account
    {
        /// <summary>
        /// Initialize  class BaseAccount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        public BaseAccount(string name, string lastname) : base(name, lastname)
        { }

        /// <summary>
        /// Update bonus points when deposit or withdraw method call
        /// </summary>
        /// <param name="amount">Money that we take or deposit</param>
        protected override void UpdateBonusPoints(int amount)
        {
            bonusPoints += amount / 100;
        }
    }
}
