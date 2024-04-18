using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(20, 25, false, true)]  // Both adults, no kids, eligible
    [InlineData(16, 25, false, false)] // First person underage, not eligible
    [InlineData(20, 16, false, false)] // Second person underage, not eligible
    [InlineData(16, 16, false, false)] // Both underage, not eligible
    [InlineData(30, 30, true, true)]   // Both adults, have kids, eligible
    [InlineData(20, 25, true, false)]  // Both adults, have kids, not eligible
    public void CanGetFamilyLoan_ShouldReturnCorrectResult(byte firstPersonAge, byte secondPersonAge, bool haveKids, bool expected)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }
}