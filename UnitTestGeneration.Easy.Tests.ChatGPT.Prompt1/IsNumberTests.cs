using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class IsNumberTests
{
    [Theory]
    [InlineData("12345")]
    [InlineData("0")]
    [InlineData("-98765")]
    public void IsNumeric_ShouldReturnTrue_ForNumericStrings(string input)
    {
        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("123abc")]
    [InlineData("12.34")]
    [InlineData(" ")]
    [InlineData(null)]
    public void IsNumeric_ShouldReturnFalse_ForNonNumericStrings(string input)
    {
        // Act
        bool result = IsNumber.IsNumeric(input);

        // Assert
        Assert.False(result);
    }
}