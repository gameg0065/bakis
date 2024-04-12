using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class CheckForPalindromeTests
{
    [Fact]
    public void TestPositivePalindrome()
    {
        int palindrome = 121;
        Assert.True(CheckForPalindrome.IsPalindrome(palindrome));
    }

    [Fact]
    public void TestNegativePalindrome()
    {
        int notPalindrome = 123;
        Assert.False(CheckForPalindrome.IsPalindrome(notPalindrome));
    }

    [Fact]
    public void TestSingleDigitPalindrome()
    {
        int singleDigit = 7;
        Assert.True(CheckForPalindrome.IsPalindrome(singleDigit));
    }

    [Fact]
    public void TestZeroPalindrome()
    {
        int zero = 0;
        Assert.True(CheckForPalindrome.IsPalindrome(zero));
    }

    [Fact]
    public void TestNegativePalindromeWithSign()
    {
        int negativePalindrome = -121;
        Assert.False(CheckForPalindrome.IsPalindrome(negativePalindrome));
    }

    [Fact]
    public void TestIntegerMaxValue()
    {
        Assert.False(CheckForPalindrome.IsPalindrome(int.MaxValue));
    }

    [Fact]
    public void TestIntegerMinValue()
    {
        Assert.False(CheckForPalindrome.IsPalindrome(int.MinValue));
    }
}