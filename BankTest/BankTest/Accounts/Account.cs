using System;
using BankTest.Accounts;

namespace BankTest
{
    public class BaseAccount : IAccount
    {
        protected double _balance;
        protected Guid _accountId;
        protected Bank _bank;
        protected double _withdrawlLimit;
        public BaseAccount(string owner, Bank bank, Guid? accountId = null)
        {
            _accountId = accountId ?? Guid.NewGuid();
            _withdrawlLimit = Double.MaxValue;
            _balance = 0;
            _bank = bank;
            Owner = owner;
        }

        public Guid AccountId => _accountId;
        public string Owner { get; set; }
        public double Balance => _balance;

        public bool Deposit(double amount)
        {
            try
            {
                _balance += amount;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Withdraw(double ammountToWithdraw) =>
            CanWithdraw(ammountToWithdraw) &&
            DoWithdraw(ammountToWithdraw);

        private bool DoWithdraw(double ammountToWithdraw)
        {
            try
            {
                _balance -= ammountToWithdraw;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CanWithdraw(double ammountToWithdraw) =>
            Balance.GreaterThanOrEqualTo(ammountToWithdraw) &&
            ammountToWithdraw.LessThanOrEqualTo(_withdrawlLimit);

        public bool Transfer(double ammountToTransfer, Guid toAccountId)
        {
            try
            {
                var toAccount = _bank.GetAccount(toAccountId);

                if (this.CanWithdraw(ammountToTransfer))
                {
                    Withdraw(ammountToTransfer);
                    toAccount.Deposit(ammountToTransfer);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }


}
