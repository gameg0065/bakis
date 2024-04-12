using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class IsNumberTests
{
    [Theory]
    [InlineData("123", true)]
    [InlineData("-789", true)]
    [InlineData("3.14159", true)]
    [InlineData("1.23e+4", true)]
    // ... more valid cases
    public void ValidNumbers_ReturnTrue(string number, bool expected)
    {
        bool result = IsNumber.IsNumeric(number);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("abc", false)]
    [InlineData("123xyz", false)]
    [InlineData("$%^&*", false)]
    [InlineData("12 34", false)]
    // ... more invalid cases
    public void InvalidNumbers_ReturnFalse(string number, bool expected)
    {
        bool result = IsNumber.IsNumeric(number);
        Assert.Equal(expected, result);
    }  

    [Theory]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void EdgeCases_ReturnFalse(string number, bool expected)
    {
        bool result = IsNumber.IsNumeric(number);
        Assert.Equal(expected, result);
    }
}