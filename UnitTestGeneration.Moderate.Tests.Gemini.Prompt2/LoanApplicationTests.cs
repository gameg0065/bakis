using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 20, true)] // Both above legal age
    [InlineData(16, 25, false)] // One person below legal age
    [InlineData(17, 17, false)] // Both at the age limit, but not above
    public void CanGetFamilyLoan_ReturnsCorrectResult(int firstAge, int secondAge, bool expected)
    {
        var result = LoanApplication.CanGetFamilyLoan(firstAge, secondAge);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1000, 500, 450)]   // Standard calculation
    [InlineData(500, 0, 150)]      // One person has no salary
    [InlineData(0, 0, 0)]           // Edge case: Both have no salary
    public void FindMonthlyPaymentSize_CalculatesCorrectly(int salary1, int salary2, int expected)
    {
        var result = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);
        Assert.Equal(expected, result);
    }

    
    [Fact]
    public void IsFamilyApplicableForLoad_Eligible_ReturnsTrue()
    {
        var ages = Tuple.Create(25, 30);
        var salaries = Tuple.Create(2000, 1500); 

        var (isEligible, payment) = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        Assert.True(isEligible);
        Assert.Equal(1050, payment); // Assert the calculated payment too
    }

    [Fact]
    public void IsFamilyApplicableForLoad_Underage_ReturnsFalse()
    {
        var ages = Tuple.Create(16, 20);
        var salaries = Tuple.Create(3000, 2000); // Salaries don't matter in this case

        var (isEligible, payment) = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        Assert.False(isEligible);
        Assert.Equal(0, payment);
    }
}