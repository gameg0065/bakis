using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class CheckForPalindromeTests
{
    [Theory]
    [InlineData(121)]
    [InlineData(1221)]
    [InlineData(12321)]
    [InlineData(123321)]
    public void IsPalindrome_ReturnsTrue_ForPalindromicNumbers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(123)]
    [InlineData(1234)]
    [InlineData(12345)]
    [InlineData(123456)]
    public void IsPalindrome_ReturnsFalse_ForNonPalindromicNumbers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.False(result);
    }
}