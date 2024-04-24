using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class IsNumberTests
{
    [Fact]
    public void IsNumeric_ValidInteger_ReturnsTrue()
    {
        // Arrange
        string number = "12345";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumeric_ValidFloatingPoint_ReturnsTrue()
    {
        // Arrange
        string number = "3.14159";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumeric_AlphanumericString_ReturnsFalse()
    {
        // Arrange
        string number = "123abc";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_NullString_ReturnsFalse()
    {
        // Arrange
        string number = null;

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_EmptyString_ReturnsFalse()
    {
        // Arrange
        string number = "";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_StringWithSpecialCharacters_ReturnsFalse()
    {
        // Arrange
        string number = "12#45";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }
}