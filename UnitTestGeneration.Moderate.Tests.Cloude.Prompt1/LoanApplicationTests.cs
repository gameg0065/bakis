using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 20, true)]
    [InlineData(16, 18, false)]
    [InlineData(17, 17, false)]
    [InlineData(20, 15, false)]
    public void CanGetFamilyLoan_ReturnsCorrectResult(int firstPersonAge, int secondPersonAge, bool expected)
    {
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2000, 3000, 1500)]
    [InlineData(5000, 0, 1500)]
    [InlineData(0, 0, 0)]
    public void FindMonthlyPaymentSize_ReturnsCorrectResult(int firstPersonSalary, int secondPersonSalary, int expected)
    {
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(18, 20, 2000, 3000, true, 1500)]
    [InlineData(16, 18, 2000, 3000, false, 1500)]
    [InlineData(20, 25, 1000, 1000, false, 600)]
    [InlineData(20, 25, 5000, 5000, true, 3000)]
    public void IsFamilyApplicableForLoan_ReturnsCorrectResult(int firstPersonAge, int secondPersonAge, int firstPersonSalary, int secondPersonSalary, bool expectedResult, int expectedPaymentSize)
    {
        // Arrange
        var ages = new Tuple<int, int>(firstPersonAge, secondPersonAge);
        var salaries = new Tuple<int, int>(firstPersonSalary, secondPersonSalary);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.Equal(expectedResult, result.Item1);
        Assert.Equal(expectedPaymentSize, result.Item2);
    }
}