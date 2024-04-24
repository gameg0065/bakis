using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class CheckForPalindromeTests
{
    [Fact]
    public void IsPalindrome_PositiveNumberPalindrome_ReturnsTrue()
    {
        // Arrange
        int input = 12321;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_PositiveNumberNonPalindrome_ReturnsFalse()
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

    [Theory]
    [InlineData(1)]
    [InlineData(121)]
    [InlineData(12321)]
    public void IsPalindrome_PositivePalindrome_ReturnsTrue(int input)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(12345)]
    [InlineData(-12321)]
    [InlineData(-123)]
    public void IsPalindrome_NonPalindrome_ReturnsFalse(int input)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(input);

        // Assert
        Assert.False(result);
    }
}