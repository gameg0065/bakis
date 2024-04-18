using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 19, true)]
    [InlineData(20, 17, false)]
    [InlineData(16, 20, false)]
    [InlineData(17, 17, false)]
    public void CanGetFamilyLoan_ValidAges_ReturnsExpectedResult(int firstAge, int secondAge, bool expected)
    {
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstAge, secondAge);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(3000, 2000, 500)]
    [InlineData(10000, 10000, 3000)]
    [InlineData(0, 0, 0)]
    public void FindMonthlyPaymentSize_ValidSalaries_ReturnsExpectedResult(int firstSalary, int secondSalary, int expected)
    {
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstSalary, secondSalary);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(18, 19, 3000, 2000, true, 500)]
    [InlineData(20, 17, 3000, 2000, false, 500)]
    [InlineData(18, 19, 5000, 5000, true, 1500)]
    [InlineData(16, 20, 5000, 5000, false, 1500)]
    [InlineData(17, 17, 5000, 5000, false, 1500)]
    public void IsFamilyApplicableForLoan_ValidInputs_ReturnsExpectedResult(
        int firstAge, int secondAge, int firstSalary, int secondSalary, bool expectedApplicable, int expectedPayment)
    {
        // Arrange
        var ages = new Tuple<int, int>(firstAge, secondAge);
        var salaries = new Tuple<int, int>(firstSalary, secondSalary);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.Equal(expectedApplicable, result.Item1);
        Assert.Equal(expectedPayment, result.Item2);
    }
}