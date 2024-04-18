using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class LoanApplicationTests
{
    [Theory]
    [InlineData(18, 20, true)]  
    [InlineData(15, 25, false)] 
    [InlineData(16, 16, false)] 
    public void CanGetFamilyLoan_ShouldReturnCorrectResult(int age1, int age2, bool expected)
    {
        var result = LoanApplication.CanGetFamilyLoan(age1, age2);
        Assert.Equal(expected, result);
    }

    // ... Similar tests for FindMonthlyPaymentSize

    [Fact]
    public void IsFamilyApplicableForLoad_Eligible_ReturnsTrue()
    {
        var ages = Tuple.Create(20, 25);
        var salaries = Tuple.Create(500, 600); 

        var (isEligible, payment) = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        Assert.True(isEligible);
        Assert.Equal(330, payment); // Calculated expected payment
    }
}