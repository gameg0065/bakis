using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class LoanApplicationTests
{
    [Fact]
    public void CanGetFamilyLoan_BothBelowLegalAge_ReturnsFalse()
    {
        var result = LoanApplication.CanGetFamilyLoan(15, 16, false);
        Assert.False(result);
    }
    [Fact]
    public void CanGetFamilyLoan_BothAboveLegalAge_ReturnsTrue()
    {
        var result = LoanApplication.CanGetFamilyLoan(20, 25, false);
        Assert.True(result);
    }
    [Fact]
    public void CanGetFamilyLoan_OneBelowLegalAge_ReturnsFalse()
    {
        var result = LoanApplication.CanGetFamilyLoan(16, 20, false);
        Assert.False(result);
    }
    [Fact]
    public void CanGetFamilyLoan_EligibleWithChildren_ReturnsTrue()
    {
        // Assuming legalAge is 17
        var result = LoanApplication.CanGetFamilyLoan(18, 20, true); 
        Assert.True(result);
    }
    [Fact]
    public void CanGetFamilyLoan_IneligibleWithChildren_ReturnsFalse()
    {
        // Assuming legalAge is 17
        var result = LoanApplication.CanGetFamilyLoan(16, 18, true); 
        Assert.False(result);
    }
}