using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class LoanApplicationTests
{
    [Fact]
    public void BothAdultsEligible_NoKids_ReturnsTrue()
    {
        bool result = LoanApplication.CanGetFamilyLoan(18, 25); 
        Assert.True(result);
    }

    [Fact]
    public void BothAdultsEligible_WithKids_ReturnsTrue()
    {
        bool result = LoanApplication.CanGetFamilyLoan(20, 35, true); 
        Assert.True(result);
    }

    [Fact]
    public void OneAdultIneligible_ReturnsFalse()
    {
        bool result = LoanApplication.CanGetFamilyLoan(16, 20);
        Assert.False(result);

        // Same test with kids - shouldn't change the outcome
        result = LoanApplication.CanGetFamilyLoan(16, 20, true);
        Assert.False(result); 
    }

    [Fact]
    public void AgesBelowThreshold_WithKids_ReturnsFalse()
    {
        bool result = LoanApplication.CanGetFamilyLoan(18, 20, true);
        Assert.False(result);
    }
}