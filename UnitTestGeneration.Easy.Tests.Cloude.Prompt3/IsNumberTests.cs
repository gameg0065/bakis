using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class IsNumberTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void IsNumeric_GivenNullOrEmptyString_ReturnsFalse(string input)
    {
        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData("123")]
    [InlineData("0")]
    [InlineData("9876543210")]
    public void IsNumeric_GivenValidNumericString_ReturnsTrue(string input)
    {
        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("123.45")]
    [InlineData("-456")]
    [InlineData("abc")]
    [InlineData("123abc")]
    [InlineData("abc123")]
    public void IsNumeric_GivenNonNumericString_ReturnsFalse(string input)
    {
        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_GivenStringWithLeadingAndTrailingSpaces_ReturnsFalse()
    {
        // Arrange
        string input = " 123 ";

        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.False(result);
    }
}