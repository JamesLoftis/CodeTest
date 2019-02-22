using System;
using BankTest.Accounts;

namespace BankTest
{
    public class CheckingAccount : BaseAccount
    {
        public CheckingAccount(string owner, Bank bank, Guid? accountId = null) : base(owner, bank, accountId){}
    }
}
