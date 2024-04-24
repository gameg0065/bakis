using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class UnitsConverterTests
{
private readonly UnitsConverter _converter;

    public UnitsConverterTests()
    {
        _converter = new UnitsConverter();
    }

    [Theory]
    [InlineData(1, 0.45359237)]
    [InlineData(10, 4.5359237)]
    [InlineData(100, 45.359237)]
    public void PoundsToKilograms_ReturnsCorrectResult(decimal pounds, decimal expected)
    {
        // Act
        decimal result = _converter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(1, 2.20462262185)]
    [InlineData(10, 22.0462262185)]
    [InlineData(100, 220.462262185)]
    public void KilogramsToPounds_ReturnsCorrectResult(decimal kilograms, decimal expected)
    {
        // Act
        decimal result = _converter.KilogramsToPounds(kilograms);

        // Assert
        Assert.Equal(expected, result, 8);
    }

    [Theory]
    [InlineData(1, 2.54)]
    [InlineData(10, 25.4)]
    [InlineData(100, 254)]
    public void InchesToCentimeters_ReturnsCorrectResult(decimal inches, decimal expected)
    {
        // Act
        decimal result = _converter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expected, result, 2);
    }

    [Theory]
    [InlineData(1, "0.39")]
    [InlineData(12.7, "5")]
    [InlineData(25.4, "1'")]
    [InlineData(38.1, "1'3")]
    [InlineData(121.92, "4'")]
    public void CentimetersToInches_ReturnsCorrectResult(decimal centimeters, string expected)
    {
        // Act
        string result = _converter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 32)]
    [InlineData(10, 50)]
    [InlineData(100, 212)]
    public void CelsiusToFahrenheit_ReturnsCorrectResult(decimal celsius, decimal expected)
    {
        // Act
        decimal result = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expected, result, 2);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(50, 10)]
    [InlineData(212, 100)]
    public void FahrenheitToCelsius_ReturnsCorrectResult(decimal fahrenheit, decimal expected)
    {
        // Act
        decimal result = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expected, result, 2);
    }
}