using System;
using NUnit;
using Moq;
using NUnit.Framework;

namespace BankTest.Tests
{
    public class DepostTests : TestBase
    {
        public DepostTests() : base(){}

        [Test]
        public void When_DepositingFirstDeposit_Should_HaveBalanceEqualToDepositAmmount()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            var ammount = 500.00;
            Assert.IsTrue(account.Balance.EqualTo(0.0));
            Assert.IsTrue(account.Deposit(ammount));
            Assert.IsTrue(account.Balance.Equals(ammount));
        }

        [Test]
        public void When_DepositingAdditionDeposit_Should_HaveBalanceEqualToDepositAmmountPlusPreviousBalance()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            var ammount = 500.00;
            account.Deposit(ammount);
            account.Deposit(ammount);
            Assert.IsTrue(account.Balance.Equals(ammount + ammount));
        }
    }
}
