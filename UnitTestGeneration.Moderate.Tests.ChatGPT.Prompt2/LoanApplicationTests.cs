using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 20, true)]
    [InlineData(18, 16, false)]
    [InlineData(15, 20, false)]
    [InlineData(15, 16, false)]
    public void CanGetFamilyLoan_ReturnsExpectedResult(int firstPersonAge, int secondPersonAge, bool expected)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2000, 3000, 500)]
    [InlineData(1500, 2500, 400)]
    [InlineData(1000, 2000, 300)]
    public void FindMonthlyPaymentSize_ReturnsExpectedResult(int firstPersonSalary, int secondPersonSalary, int expected)
    {
        // Act
        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(18, 20, 2000, 3000, true, 500)]
    [InlineData(18, 16, 2000, 3000, false, 500)]
    [InlineData(15, 20, 2000, 3000, false, 500)]
    [InlineData(15, 16, 2000, 3000, false, 500)]
    public void IsFamilyApplicableForLoan_ReturnsExpectedResult(int firstPersonAge, int secondPersonAge, int firstPersonSalary, int secondPersonSalary, bool expectedEligibility, int expectedMonthlyPayment)
    {
        // Arrange
        var ages = new Tuple<int, int>(firstPersonAge, secondPersonAge);
        var salaries = new Tuple<int, int>(firstPersonSalary, secondPersonSalary);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.Equal(expectedEligibility, result.Item1);
        Assert.Equal(expectedMonthlyPayment, result.Item2);
    }
}