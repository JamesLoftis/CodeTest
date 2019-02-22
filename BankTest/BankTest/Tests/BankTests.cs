using System;
using NUnit;
using Moq;
using NUnit.Framework;

namespace BankTest.Tests
{
    public class BankTests : TestBase
    {
        [Test]
        public void When_CreatingAccount_Should_ExisitInAccountsList()
        {
            var id = Guid.NewGuid();
            var newAccountId = TestBank.CreateNewAccount<BaseAccount>("", id);
            Assert.AreEqual(id, newAccountId);
        }

        public void When_FindingAccountThatExists_Should_ReuturnRequestedAccount()
        {

        }

        public void When_FindingAccountThatDoesntExist_Should_ReuturnNullAccount()
        {

        }
    }
}
