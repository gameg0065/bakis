using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class IsNumberTests
{
    [Fact]
    public void IsNumeric_NullString_ReturnsFalse()
    {
        string input = null;
        var result = IsNumber.IsNumeric(input);
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_EmptyString_ReturnsFalse()
    {
        string input = "";
        var result = IsNumber.IsNumeric(input);
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_ValidInteger_ReturnsTrue()
    {
        string input = "12345";
        var result = IsNumber.IsNumeric(input);
        Assert.True(result);
    }

    [Fact]
    public void IsNumeric_StringWithNonDigit_ReturnsFalse()
    {
        string input = "123abc";
        var result = IsNumber.IsNumeric(input);
        Assert.False(result);
    }

    [Fact]
    public void IsNumeric_StringWithWhitespace_ReturnsFalse()
    {
        string input = "123 45"; 
        var result = IsNumber.IsNumeric(input);
        Assert.False(result);
    }

    // Consider adding tests for:
    // - Decimal numbers (e.g., "123.45")
    // - Negative numbers (e.g., "-123")
    // - Scientific notation (e.g., "1.23e4") - Decide if this is relevant
}