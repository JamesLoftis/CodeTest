using System;
namespace BankTest.Accounts
{
    public class SavingsAccount : BaseAccount
    {
        public SavingsAccount(string owner, Bank bank, Guid? accountId) : base(owner, bank, accountId){}
    }
}
