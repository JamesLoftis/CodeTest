using System;
namespace BankTest
{
    public class IndividualCheckingAccount : CheckingAccount
    {
        public IndividualCheckingAccount(string owner, Bank bank, Guid? accountId = null) : base(owner, bank, accountId)
        {
            _withdrawlLimit = 1000;
        }
    }
}
