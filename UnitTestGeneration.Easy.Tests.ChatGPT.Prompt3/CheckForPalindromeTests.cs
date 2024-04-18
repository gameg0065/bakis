using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class CheckForPalindromeTests
{
    [Theory]
    [InlineData(121, true)] // Palindrome number
    [InlineData(12321, true)] // Palindrome number
    [InlineData(1234321, true)] // Palindrome number
    [InlineData(123456, false)] // Non-palindrome number
    [InlineData(10, false)] // Non-palindrome number
    [InlineData(-121, false)] // Negative non-palindrome number
    public void IsPalindrome_ShouldReturnCorrectResult(int input, bool expected)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }
}