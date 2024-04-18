using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class UnitsConverterTests
{
    [Fact]
    public void PoundsToKilograms_ZeroPounds_ReturnsZeroKilograms()
    {
        var converter = new UnitsConverter();
        var result = converter.PoundsToKilograms(0);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void PoundsToKilograms_PositiveValue_ReturnsCorrectConversion()
    {
        var converter = new UnitsConverter();
        var result = converter.PoundsToKilograms(10);
        Assert.Equal(4.5359237m, result); // Adjust expected value with more precision if needed
    }
    
    [Fact]
    public void CentimetersToInches_ConvertsToFeet_ReturnsCorrectString()
    {
        var converter = new UnitsConverter();
        var result = converter.CentimetersToInches(36); // Value that converts to 1 foot 
        Assert.Equal("1'", result);
    }
}