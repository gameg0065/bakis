using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class CheckForPalindromeTests
{
    [Fact]
    public void IsPalindrome_PositivePalindrome_ReturnsTrue()
    {
        int x = 12321;
        bool result = CheckForPalindrome.IsPalindrome(x);
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NegativePalindrome_ReturnsTrue()
    {
        int x = -101;
        bool result = CheckForPalindrome.IsPalindrome(x);
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        int x = 1234;
        bool result = CheckForPalindrome.IsPalindrome(x);
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_SingleDigit_ReturnsTrue()
    {
        int x = 7;
        bool result = CheckForPalindrome.IsPalindrome(x);
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_Zero_ReturnsTrue()
    {
        int x = 0;
        bool result = CheckForPalindrome.IsPalindrome(x);
        Assert.True(result);
    }
}