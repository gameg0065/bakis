using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class LoanApplicationTests
{
[Theory]
    [InlineData(18, 18)]
    [InlineData(20, 25)]
    [InlineData(30, 40)]
    public void CanGetFamilyLoan_WhenBothAgesAboveLegalAge_ReturnsTrue(int firstPersonAge, int secondPersonAge)
    {
        // Arrange
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(16, 18)]
    [InlineData(15, 20)]
    [InlineData(10, 12)]
    public void CanGetFamilyLoan_WhenOneAgeUnderLegalAge_ReturnsFalse(int firstPersonAge, int secondPersonAge)
    {
        // Arrange
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanGetFamilyLoan_WhenBothAgesOnLegalAge_ReturnsFalse()
    {
        // Arrange
        int firstPersonAge = 17;
        int secondPersonAge = 17;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1000, 2000)]
    [InlineData(5000, 5000)]
    [InlineData(10000, 20000)]
    public void FindMonthlyPaymentSize_WithValidSalaries_ReturnsCorrectPayment(int firstPersonSalary, int secondPersonSalary)
    {
        // Arrange
        int expectedPayment = (firstPersonSalary + secondPersonSalary) / 10 * 3;

        // Act
        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal(expectedPayment, result);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_WhenBothAgesUnderLegalAge_ReturnsFalseAndZeroPayment()
    {
        // Arrange
        Tuple<int, int> ages = new Tuple<int, int>(16, 15);
        Tuple<int, int> salaries = new Tuple<int, int>(1000, 2000);

        // Act
        Tuple<bool, int> result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.False(result.Item1);
        Assert.Equal(0, result.Item2);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_WhenPaymentSizeBelowMinimum_ReturnsFalseAndCorrectPayment()
    {
        // Arrange
        Tuple<int, int> ages = new Tuple<int, int>(20, 25);
        Tuple<int, int> salaries = new Tuple<int, int>(500, 500);
        int expectedPayment = (500 + 500) / 10 * 3;

        // Act
        Tuple<bool, int> result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.False(result.Item1);
        Assert.Equal(expectedPayment, result.Item2);
    }

    [Fact]
    public void IsFamilyApplicableForLoad_WhenEligibleForLoan_ReturnsTrueAndCorrectPayment()
    {
        // Arrange
        Tuple<int, int> ages = new Tuple<int, int>(25, 30);
        Tuple<int, int> salaries = new Tuple<int, int>(5000, 10000);
        int expectedPayment = (5000 + 10000) / 10 * 3;

        // Act
        Tuple<bool, int> result = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        // Assert
        Assert.True(result.Item1);
        Assert.Equal(expectedPayment, result.Item2);
    }
}