using System;
using Xunit;
using BankingService;
using FluentAssertions;

namespace BankingService.Tests
{
    public class UserTest_ToString
    {
        [Fact]
        public void Should_ReturnFullName_WhenUserHasFirstAndLastNames()
        {
            // Arrange/Given/Setup
            User user = new User { First = "Bob", Last = "Smith" };
            // Act/When/Exercise
            string fullName = user.ToString();
            // Assert/Then/Assert
            fullName.Should().Be("Bob Smith");
        }
    }
}