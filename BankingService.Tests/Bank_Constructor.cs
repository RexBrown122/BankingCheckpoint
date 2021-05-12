using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
  public class Bank_Constructor
  {
    [Fact]
    public void Should_InitializeBankAccounts_as0()
    {
      // Arrange
      Bank bank1 = new Bank();
      // Act
      // Assert
      bank1.Accounts.Should().HaveCount(0);
    }
  }
}