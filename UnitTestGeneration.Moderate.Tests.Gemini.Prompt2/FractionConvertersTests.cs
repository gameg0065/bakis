using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class FractionConvertersTests
{
    [Fact]
    public void SafeDivision_ZeroNumerator_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(0, 10));
    }

    [Fact]
    public void SafeDivision_ZeroDenominator_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(10, 0));
    }

    [Fact]
    public void SafeDivision_ValidInput_ReturnsResult()
    {
        var result = FractionConverters.SafeDivision(10, 2);
        Assert.Equal(5, result);
    }
    [Fact]
    public void SafeDivision_ZeroNumerator_ThrowsException1()
    {
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(0, 10));
    }

    [Fact]
    public void SafeDivision_ZeroDenominator_ThrowsException2()
    {
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(10, 0));
    }

    [Fact]
    public void SafeDivision_ValidInput_ReturnsResult3()
    {
        var result = FractionConverters.SafeDivision(10, 2);
        Assert.Equal(5, result);
    }
    [Fact]
    public void InchesSplit_ValidInput_ReturnsConvertedDecimal()
    {
        var result = new FractionConverters().InchesSplit("66'8\"");
        Assert.Equal(808m, result);
    }

    [Fact]
    public void InchesSplit_InvalidInput_HandlesError() // Decide how to handle
    {
        var result = new FractionConverters().InchesSplit("hello world");
        // Assert based on how you intend to handle invalid input
    }

    
}