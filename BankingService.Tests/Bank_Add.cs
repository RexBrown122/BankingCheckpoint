using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
  public class Bank_Add
  {
    [Fact]
    public void AddAccount_shouldContainAccount()
    {
      // Arrange
      Bank bank1 = new Bank();
      Account account = new Account("CX-3", "Monica", "Barns");
      // Act
      bank1.AddAccount(account);
      // Assert
      bank1.Accounts.Should().Contain(account);
    }

    [Fact]
    public void AddAccount_beAbleToAddMultipleAccounts()
    {
      // Arrange
      Bank bank1 = new Bank();
      Account account1 = new Account("CX-3123", "Steven", "Wang");
      Account account2 = new Account("CX-3232", "Lewis", "Wooler");
      Account account3 = new Account("CX-3423", "Rex", "Brown");
      Account account4 = new Account("CX-3235", "Andrew", "Mitschke");
      // Act
      bank1.AddAccount(account1);
      bank1.AddAccount(account2);
      bank1.AddAccount(account3);
      bank1.AddAccount(account4);
      // Assert
      bank1.Accounts.Should().HaveCount(4);
    }

  }
}