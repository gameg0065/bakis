namespace UnitTestGeneration.Easy.Tests;

public class UnitTest1
{
    [Fact]
    public void CalculateLoan()
    {
        // Arrange
        const int firstPersonSalary = 1400;
        const int secondPersonSalary = 1200;
        const int expectedResult = 780;
        
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
    
    [Fact]
    public void CalculateLoanWhenNegative()
    {
        // Arrange
        const int firstPersonSalary = 2500;
        const int secondPersonSalary = -500;
        const int expectedResult = 600;
        
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.True(result.Equals(expectedResult));
    }
}