using System;
using NUnit.Framework;

namespace BankTest.Tests
{
    public class TransferTests : TestBase
    {
        public TransferTests() : base(){}

        [Test]
        public void When_TransferringSomeAmmount_Should_RemoveThatAmmountFromOriginAndAddItToDestination()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            var destinationId = TestBank.CreateNewAccount<IndividualCheckingAccount>("test");
            account.Deposit(500.00);

            Assert.IsTrue(account.Transfer(500.00, destinationId));
            Assert.IsTrue(account.Balance.EqualTo(0.0));
            Assert.IsTrue(TestBank.GetAccount(destinationId).Balance.EqualTo(500.00));
        }

        [Test]
        public void When_ATransferFails_Should_NotChangeBalancesOfEitherAccount()
        {
            SetUp();
            var account = TestBank.GetAccount(AccountId);
            var destinationId = TestBank.CreateNewAccount<IndividualCheckingAccount>("test");
            account.Deposit(500.00);
            Assert.IsFalse(account.Transfer(1000.00, destinationId));
            Assert.IsTrue(account.Balance.EqualTo(500.00));
            Assert.IsTrue(TestBank.GetAccount(destinationId).Balance.EqualTo(0.00));
        }
    }
}
