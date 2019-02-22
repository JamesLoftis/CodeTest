using System;
using System.Collections.Generic;
using System.Linq;
using BankTest.Accounts;

namespace BankTest
{
    public class Bank
    {
        public Bank()
        {
            Accounts = new List<IAccount>();
            NULLACCOUNT = new BaseAccount("NullAccount", this);
        }
        public IAccount NULLACCOUNT { get; }
        public string Name { get; set; }
        public List<IAccount> Accounts { get; set; }
        public bool AccountExists(Guid accountId) => Accounts.Any(x => x.AccountId == accountId);
        public IAccount GetAccount(Guid accountID)
        {
            if(AccountExists(accountID))
            {
                return Accounts.First(x => x.AccountId == accountID);
            }
            return NULLACCOUNT;
        }

        public Guid CreateNewAccount<T>(string owner, Guid? providedId = null) where T : BaseAccount, IAccount
        {
            var newAccount = (T)Activator.CreateInstance(typeof(T), new object[] {owner, this, providedId});
            Accounts.Add(newAccount);
            return newAccount.AccountId;
        }
    }
}
