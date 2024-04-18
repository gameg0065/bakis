using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class IsNumberTests
{
    [Fact]
    public void IsNumeric_ShouldReturnFalse_ForEmptyString()
    {
        // Arrange
        string emptyString = "";

        // Act
        bool result = IsNumber.IsNumeric(emptyString);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("123a")]
    [InlineData("1.23")]
    [InlineData("12 3")]
    public void IsNumeric_ShouldReturnFalse_ForNonNumericString(string nonNumericString)
    {
        // Act
        bool result = IsNumber.IsNumeric(nonNumericString);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData("123")]
    [InlineData("456789")]
    [InlineData("0")]
    public void IsNumeric_ShouldReturnTrue_ForNumericString(string numericString)
    {
        // Act
        bool result = IsNumber.IsNumeric(numericString);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumeric_ShouldReturnFalse_ForNullString()
    {
        // Arrange
        string nullString = null;

        // Act
        bool result = IsNumber.IsNumeric(nullString);

        // Assert
        Assert.False(result);
    }
}