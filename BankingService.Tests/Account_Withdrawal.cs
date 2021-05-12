using System;
using Xunit;
using BankingService;
using FluentAssertions;

namespace BankingService.Tests{
    public class Account_Withdrawal{
        [Fact]
        public void Withdrawal_PositiveAmountWhenEmpty_ThrowsException()
        {
            // Arrange
            Account account = new Account("ad12", "Andrew", "Michael");
            // Act
            Action action = () =>  account.Withdrawal(20);
            // Assert
            action.Should().Throw<ApplicationException>()
            .WithMessage("Amount is greater than balance");
            account.Transactions.Should().HaveCount(0);
        }
        [Fact]
        public void Withdrawal_NegativeAmount_ThrowsException()
        {
            // Arrange
            Account account = new Account("ad12", "Andrew", "Michael");
            // Act
            Action action = () =>  account.Withdrawal(-20);
            // Assert
            action.Should().Throw<ApplicationException>()
            .WithMessage("Cannot withdraw negative amounts");
            account.Transactions.Should().HaveCount(0);
        }

        [Fact]
        public void Withdrawal_PositiveAmount_DecreasesBalance()
        {
        // Arrange
            Account account = new Account("ad12", "Andrew", "Michael");
            account.Deposit(100);
        //Act
            account.Withdrawal(20);
        // Assert
            account.Balance.Should().Be(80);
            account.Transactions[1].Should().Be("Withdrawal: $20");
        }

                [Fact]
        public void Withdrawal_MultiplePositiveAmount_DecreaseBalance()
        {
        // Arrange
            Account account = new Account("ad12", "Andrew", "Michael");
            account.Deposit(100);
        //Act
            account.Withdrawal(20);
            account.Withdrawal(80);
        // Assert
            account.Balance.Should().Be(0);
            account.Transactions.Should().HaveCount(3);
        }

    }
}