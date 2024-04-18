using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class IsNumberTests
{
    [Theory]
    [InlineData("12345")] // Valid numeric string
    [InlineData("0")] // Valid numeric string
    [InlineData("-12345")] // Valid numeric string
    [InlineData("1.23")] // Valid numeric string (considered as non-integer)
    public void IsNumeric_ShouldReturnTrue_ForValidNumericStrings(string number)
    {
        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("abc")] // Invalid non-numeric string
    [InlineData("12a34")] // Invalid non-numeric string
    [InlineData("1 2 3")] // Invalid non-numeric string
    [InlineData("")] // Empty string
    [InlineData(" ")] // String with one space
    public void IsNumeric_ShouldReturnFalse_ForInvalidNonNumericStrings(string number)
    {
        // Act
        bool result = IsNumber.IsNumeric(number);

        // Assert
        Assert.False(result);
    }
}