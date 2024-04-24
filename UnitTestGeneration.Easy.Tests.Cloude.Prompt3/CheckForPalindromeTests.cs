using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class CheckForPalindromeTests
{
    [Theory]
    [InlineData(121)] // Palindrome positive integer
    [InlineData(1221)] // Palindrome positive integer with more than 2 digits
    public void IsPalindrome_PositiveInteger_ReturnsTrue(int input)
    {
        bool result = CheckForPalindrome.IsPalindrome(input);
        Assert.True(result);
    }

    [Theory]
    [InlineData(-121)] // Negative palindrome integer
    [InlineData(0)] // Zero
    public void IsPalindrome_NonPalindrome_ReturnsFalse(int input)
    {
        bool result = CheckForPalindrome.IsPalindrome(input);
        Assert.False(result);
    }

    [Theory]
    [InlineData(12321)] // Non-palindrome positive integer
    [InlineData(123456)] // Non-palindrome positive integer with even number of digits
    public void IsPalindrome_NonPalindromePositiveInteger_ReturnsFalse(int input)
    {
        bool result = CheckForPalindrome.IsPalindrome(input);
        Assert.False(result);
    }

    [Theory]
    [InlineData(int.MinValue)] // Minimum integer value
    [InlineData(int.MaxValue)] // Maximum integer value
    public void IsPalindrome_IntegerOverflowEdgeCases_ReturnsExpectedResult(int input)
    {
        bool expectedResult = input.ToString() == (new string(input.ToString().Reverse().ToArray()));
        bool result = CheckForPalindrome.IsPalindrome(input);
        Assert.Equal(expectedResult, result);
    }
}