using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class FractionConvertersTests
{
    [Fact]
    public void Fraction_ValidInput_ReturnsCorrectDecimal()
    {
        FractionConverters converter = new FractionConverters();

        decimal result = converter.Fraction("3/4");
        Assert.Equal(0.75m, result);  

        result = converter.Fraction("1/8");
        Assert.Equal(0.125m, result);  
    }

    [Fact]
    public void Fraction_ZeroDenominator_ThrowsException()
    {
        FractionConverters converter = new FractionConverters();
        Assert.Throws<DivideByZeroException>(() => converter.Fraction("5/0"));
    }

    [Fact]
    public void Fraction_InvalidFormat_ThrowsException()
    {
        FractionConverters converter = new FractionConverters();
        Assert.Throws<FormatException>(() => converter.Fraction("hello/world")); 
    }

    [Fact]
    public void InchesSplit_TypicalInput_ReturnsCorrectDecimal()
    {
        FractionConverters converter = new FractionConverters();
        decimal result = converter.InchesSplit("6'7");
        Assert.Equal(79m, result); 
    }

    // ... Add more tests for InchesSplit ...

    [Fact]
    public void SafeDivision_ZeroNumerator_ReturnsZero()
    {
        decimal result = FractionConverters.SafeDivision(0, 5);
        Assert.Equal(0m, result);
    }

    [Fact]
    public void SafeDivision_ZeroDenominator_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(5, 0));
    }   
}