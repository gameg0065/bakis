using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class IsNumberTests
{
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
        string number = string.Empty;

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_ValidNumericString_ReturnsTrue()
    {
        // Arrange
        string number = "12345";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNumeric_StringWithNonNumericCharacters_ReturnsFalse()
    {
        // Arrange
        string number = "123a45";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_StringWithDecimalPoint_ReturnsFalse()
    {
        // Arrange
        string number = "123.45";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_StringWithNegativeSign_ReturnsFalse()
    {
        // Arrange
        string number = "-123";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_StringWithLeadingZeroes_ReturnsTrue()
    {
        // Arrange
        string number = "00123";

        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.True(result);
    }
}