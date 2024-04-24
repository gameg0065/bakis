using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class CheckForPalindromeTests
{
    [Fact]
    public void IsPalindrome_SingleDigit_ReturnsTrue()
    {
        // Arrange
        int input = 5;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_Palindrome_ReturnsTrue()
    {
        // Arrange
        int input = 12321;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        int input = 12345;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_NegativeNumber_ReturnsFalse()
    {
        // Arrange
        int input = -12321;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_Zero_ReturnsTrue()
    {
        // Arrange
        int input = 0;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }
}