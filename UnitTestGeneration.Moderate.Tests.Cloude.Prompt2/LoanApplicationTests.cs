using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class LoanApplicationTests
{
[Theory]
    [InlineData(18, 18)]
    [InlineData(20, 25)]
    [InlineData(30, 40)]
    public void CanGetFamilyLoan_WhenBothAgesAboveLegalAge_ReturnsTrue(int firstPersonAge, int secondPersonAge)
    {
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(16, 18)]
    [InlineData(17, 15)]
    [InlineData(10, 12)]
    public void CanGetFamilyLoan_WhenAtLeastOneAgeUnderLegalAge_ReturnsFalse(int firstPersonAge, int secondPersonAge)
    {
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1000, 2000)]
    [InlineData(5000, 10000)]
    [InlineData(0, 0)]
    public void FindMonthlyPaymentSize_ValidSalaries_ReturnsCorrectPaymentSize(int firstPersonSalary, int secondPersonSalary)
    {
        // Act
        var result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal((firstPersonSalary + secondPersonSalary) / 10 * 3, result);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_BothAgesUnderLegalAge_ReturnsFalseAndZeroPaymentSize()
    {
        // Arrange
        var ages = new Tuple<int, int>(16, 15);
        var salaries = new Tuple<int, int>(1000, 2000);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.False(result.Item1);
        Assert.Equal(0, result.Item2);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_BothAgesAboveLegalAge_PaymentSizeAboveMinimum_ReturnsTrueAndPaymentSize()
    {
        // Arrange
        var ages = new Tuple<int, int>(25, 30);
        var salaries = new Tuple<int, int>(5000, 10000);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.True(result.Item1);
        Assert.Equal(4500, result.Item2);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_BothAgesAboveLegalAge_PaymentSizeBelowMinimum_ReturnsFalseAndPaymentSize()
    {
        // Arrange
        var ages = new Tuple<int, int>(20, 22);
        var salaries = new Tuple<int, int>(500, 1000);

        // Act
        var result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.False(result.Item1);
        Assert.Equal(45, result.Item2);
    }
}