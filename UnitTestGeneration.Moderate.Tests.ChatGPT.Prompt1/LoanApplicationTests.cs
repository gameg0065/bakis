using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 20, true)]
    [InlineData(16, 18, false)]
    [InlineData(20, 16, false)]
    [InlineData(20, 20, true)]
    public void CanGetFamilyLoan_ReturnsExpectedResult(int firstPersonAge, int secondPersonAge, bool expectedResult)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(3000, 4000, 700)]
    [InlineData(5000, 6000, 1100)]
    [InlineData(2000, 2000, 600)]
    public void FindMonthlyPaymentSize_ReturnsExpectedResult(int firstPersonSalary, int secondPersonSalary, int expectedMonthlyPayment)
    {
        // Act
        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal(expectedMonthlyPayment, result);
    }

    [Theory]
    [InlineData(18, 20, 3000, 4000, true, 700)]
    [InlineData(16, 18, 3000, 4000, false, 0)]
    [InlineData(20, 16, 3000, 4000, false, 0)]
    [InlineData(20, 20, 3000, 4000, true, 700)]
    public void IsFamilyApplicableForLoad_ReturnsExpectedResult(int firstPersonAge, int secondPersonAge, int firstPersonSalary, int secondPersonSalary, bool expectedEligibility, int expectedMonthlyPayment)
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