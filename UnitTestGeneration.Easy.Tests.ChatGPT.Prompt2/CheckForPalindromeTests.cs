using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class CheckForPalindromeTests
{
    [Theory]
    [InlineData(121)]
    [InlineData(1221)]
    [InlineData(12321)]
    [InlineData(123321)]
    public void IsPalindrome_ShouldReturnTrue_ForPalindromicNumbers(int number)
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
    public void IsPalindrome_ShouldReturnFalse_ForNonPalindromicNumbers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(9)]
    public void IsPalindrome_ShouldReturnTrue_ForSingleDigitNumbers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(-121)]
    [InlineData(-1221)]
    [InlineData(-12321)]
    public void IsPalindrome_ShouldReturnFalse_ForNegativeNumbers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_ShouldReturnTrue_ForZero()
    {
        // Arrange
        int number = 0;

        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void IsPalindrome_ShouldHandleMinMaxIntegers(int number)
    {
        // Act
        bool result = CheckForPalindrome.IsPalindrome(number);

        // Assert
        Assert.False(result); // Min and max integers are not palindromes
    }
}