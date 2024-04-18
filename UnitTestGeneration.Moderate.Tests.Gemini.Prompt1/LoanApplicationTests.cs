using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class LoanApplicationTests
{
    // Tests for CanGetFamilyLoan
    [Theory]
    [InlineData(18, 20, true)]
    [InlineData(16, 25, false)] 
    [InlineData(30, 15, false)] 
    // Add more cases to test boundary conditions
    public void CanGetFamilyLoan_ReturnsCorrectEligibility(int age1, int age2, bool expected)
    {
        var result = LoanApplication.CanGetFamilyLoan(age1, age2);
        Assert.Equal(expected, result);
    }

    // Tests for FindMonthlyPaymentSize
    [Theory]
    [InlineData(2000, 3000, 1500)] 
    [InlineData(0, 500, 150)]     
    // Add more cases with different salary combinations
    public void FindMonthlyPaymentSize_CalculatesCorrectly(int salary1, int salary2, int expected) 
    {
        var result = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);
        Assert.Equal(expected, result);
    }

    // Tests for IsFamilyApplicableForLoad
    [Fact]
    public void IsFamilyApplicableForLoad_EligibleFamily_SufficientPayment()
    {
        var ages = new Tuple<int, int>(20, 25);
        var salaries = new Tuple<int, int>(5000, 3000);

        var (isEligible, paymentSize) = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        Assert.True(isEligible);
        Assert.Equal(2400, paymentSize); // Calculate expected payment size
    }

    [Fact]
    public void IsFamilyApplicableForLoad_IneligibleAge()
    {
        var ages = new Tuple<int, int>(16, 25);
        var salaries = new Tuple<int, int>(5000, 3000);  

        var (isEligible, paymentSize) = LoanApplication.IsFamilyApplicableForLoad(ages, salaries);

        Assert.False(isEligible);
        Assert.Equal(0, paymentSize);
    }
}