using System;
namespace BankTest.Tests
{
    public class TestBase
    {
        public Bank TestBank { get; set; }
        public const string Owner = "person1";
        public Guid AccountId { get; set; }
        public TestBase()
        {
            SetUp();
        }
        public void SetUp()
        {
            AccountId = Guid.NewGuid();
            TestBank = new Bank();
            TestBank.CreateNewAccount<IndividualCheckingAccount>(Owner, AccountId);
        }
    }
}
