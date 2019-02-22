using System;
namespace BankTest.Accounts
{
    public class EmptyAccount
    {
        public static IAccount EMPTYACCOUNT { get; }




        public EmptyAccount() : base(string.Empty, null)
        {
            _balance = 0;
            _accountId = Guid.Empty;
            _withdrawlLimit = 0;
        }
    }
}
