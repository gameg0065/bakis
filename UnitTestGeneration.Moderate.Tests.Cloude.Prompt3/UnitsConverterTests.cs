using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class UnitsConverterTests
{
private readonly UnitsConverter _converter;

    public UnitsConverterTests()
    {
        _converter = new UnitsConverter();
    }

    [Theory]
    [InlineData(1, 0.45359237)]
    [InlineData(0, 0)]
    [InlineData(-10, -4.5359237)]
    public void PoundsToKilograms_ReturnsCorrectValue(decimal pounds, decimal expectedKilograms)
    {
        // Act
        decimal result = _converter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expectedKilograms, result);
    }

    [Theory]
    [InlineData(1, 2.20462262185)]
    [InlineData(0, 0)]
    [InlineData(-5, -11.0231131093)]
    public void KilogramsToPounds_ReturnsCorrectValue(decimal kilograms, decimal expectedPounds)
    {
        // Act
        decimal result = _converter.KilogramsToPounds(kilograms);

        // Assert
        Assert.Equal(expectedPounds, result);
    }

    [Theory]
    [InlineData(1, 2.54)]
    [InlineData(0, 0)]
    [InlineData(-10, -25.4)]
    public void InchesToCentimeters_ReturnsCorrectValue(decimal inches, decimal expectedCentimeters)
    {
        // Act
        decimal result = _converter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expectedCentimeters, result);
    }

    [Theory]
    [InlineData(1, "0.39")]
    [InlineData(12, "1'")]
    [InlineData(24, "2'")]
    [InlineData(36, "3'")]
    [InlineData(0, "0")]
    [InlineData(-10, "-3.94")]
    public void CentimetersToInches_ReturnsCorrectValue(decimal centimeters, string expectedInches)
    {
        // Act
        string result = _converter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expectedInches, result);
    }

    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void CelsiusToFahrenheit_ReturnsCorrectValue(decimal celsius, decimal expectedFahrenheit)
    {
        // Act
        decimal result = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expectedFahrenheit, result);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    public void FahrenheitToCelsius_ReturnsCorrectValue(decimal fahrenheit, decimal expectedCelsius)
    {
        // Act
        decimal result = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expectedCelsius, result);
    }
}