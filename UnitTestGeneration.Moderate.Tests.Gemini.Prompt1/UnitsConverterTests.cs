using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class UnitsConverterTests
{
    [Fact]
    public void PoundsToKilograms_ConvertsCorrectly()
    {
        var converter = new UnitsConverter();

        Assert.Equal(4.5359237m, converter.PoundsToKilograms(10m));
        Assert.Equal(22.6796185m, converter.PoundsToKilograms(50m));
    }

    [Fact]
    public void KilogramsToPounds_ConvertsCorrectly()
    {
        var converter = new UnitsConverter();

        Assert.Equal(22.0462262185m, converter.KilogramsToPounds(10m));
        Assert.Equal(110.2311310925m, converter.KilogramsToPounds(50m));
    }

    // Tests for Inches/Centimeters conversions
    [Fact]
    public void InchesToCentimeters_ConvertsCorrectly()
    {
        var converter = new UnitsConverter();

        Assert.Equal(12.7m, converter.InchesToCentimeters(5m));
        Assert.Equal(25.4m, converter.InchesToCentimeters(10m));
    }

    [Fact]
    public void CentimetersToInches_FormatsWithFeetCorrectly()
    {
        var converter = new UnitsConverter();

        Assert.Equal("1'", converter.CentimetersToInches(30.48m));
        Assert.Equal("2'5\"", converter.CentimetersToInches(76.2m)); 
    }

    [Fact]
    public void CentimetersToInches_FormatsWithoutFeetCorrectly()
    {
        var converter = new UnitsConverter();

        Assert.Equal("10", converter.CentimetersToInches(25.4m));
        Assert.Equal("4.5", converter.CentimetersToInches(11.43m));
    }
}