using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests;

public class UnitTest1
{
    [Fact]
    public void CalculateLoan()
    {
        // Arrange
        Random rnd = new Random();
        var firstPersonSalary = (ushort) rnd.Next(ushort.MaxValue);
        var secondPersonSalary = (ushort) rnd.Next(ushort.MaxValue);
        var expectedResult = (firstPersonSalary + secondPersonSalary) / 10 * 3;
        
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.True(result.Equals(expectedResult));
    }
    
    [Fact]
    public void CalculateLoanWhenZero()
    {
        // Arrange
        const int firstPersonSalary = 0;
        const int secondPersonSalary = 0;
        const int expectedResult = 0;
        
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.True(result.Equals(expectedResult));
    }
}