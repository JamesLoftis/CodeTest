using System;
using NUnit.Framework;

namespace BankTest.Tests
{
    public class WithdrawTests : TestBase
    {
        public WithdrawTests() : base() { }

        [Test]
        public void When_WithdrawingSomeAmmount_Should_HaveBalanceEqualPreviousAmmountMinusWithdrawedAmmount()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            account.Deposit(500.00);
            Assert.IsTrue(account.Balance.EqualTo(500.00));
            Assert.IsTrue(account.Withdraw(250.00));
            Assert.IsTrue(account.Balance.EqualTo(250.00));
        }

        [Test]
        public void When_AttemptingToWithdrawMoreThanIsAvailable_Should_FailToWithdraw()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            account.Deposit(500.00);
            Assert.IsFalse(account.Withdraw(1000.00));
            Assert.IsTrue(account.Balance.EqualTo(500.00));
        }

        [Test]
        public void When_AttemptingToWithdrawMoreThanIsLimit_Should_FailToWithdraw()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            account.Deposit(50000.00);
            Assert.IsTrue(account.Balance.EqualTo(50000.00));
            Assert.IsFalse(account.Withdraw(25000.00));
            Assert.IsTrue(account.Balance.EqualTo(50000.00));
        }
    }
}
