using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class IsNumberTests
{
    [Fact]
    public void TestNumericString()
    {
        string number = "12345";
        Assert.True(IsNumber.IsNumeric(number));
    }

    [Fact]
    public void TestNonNumericString()
    {
        string number = "123abc";
        Assert.False(IsNumber.IsNumeric(number));
    }

    [Fact]
    public void TestEmptyString()
    {
        string number = "";
        Assert.False(IsNumber.IsNumeric(number));
    }

    [Fact]
    public void TestNullString()
    {
        string number = null;
        Assert.False(IsNumber.IsNumeric(number));
    }

    [Fact]
    public void TestStringWithSpaces()
    {
        string number = " 123 ";
        Assert.False(IsNumber.IsNumeric(number));
    }

    [Fact]
    public void TestDecimalNumber()
    {
        string number = "123.45";  
        Assert.False(IsNumber.IsNumeric(number)); // Modify if you want decimals to be valid
    }

    [Fact]
    public void TestNegativeNumber()
    {
        string number = "-123";
        Assert.False(IsNumber.IsNumeric(number)); // Modify if you want negatives to be valid
    }
}