using System;
namespace BankTest
{
    public class MoneyMarketCheckingAccount : CheckingAccount
    {
        public MoneyMarketCheckingAccount(string owner, Bank bank, Guid? accountId) : base(owner, bank, accountId){}
    }
}
