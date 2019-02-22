using System;
namespace BankTest.Accounts
{
    public interface IAccount
    {
        bool Withdraw(double ammountToWithdraw);
        bool Deposit(double ammountToDeposit);
        bool Transfer(double ammountToTransfer, Guid toAccount);
        string Owner { get; set; }
        double Balance { get; }
        Guid AccountId { get; }
    }
}
