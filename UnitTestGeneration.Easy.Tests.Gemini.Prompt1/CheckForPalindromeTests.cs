using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class CheckForPalindromeTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(5445, true)]
    [InlineData(-101, true)]
    public void PalindromeNumbers_ReturnTrue(int num, bool expected)
    {
        bool result = CheckForPalindrome.IsPalindrome(num);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(123, false)]
    [InlineData(4567, false)]
    [InlineData(891, false)]
    public void NonPalindromeNumbers_ReturnFalse(int num, bool expected)
    {
        bool result = CheckForPalindrome.IsPalindrome(num);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SingleDigitNumber_ReturnsTrue()
    {
        int num = 7; 
        bool result = CheckForPalindrome.IsPalindrome(num);
        Assert.True(result);
    }
}