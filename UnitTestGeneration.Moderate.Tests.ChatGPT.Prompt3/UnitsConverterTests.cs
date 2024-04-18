using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class UnitsConverterTests
{
    private readonly UnitsConverter converter;

    public UnitsConverterTests()
    {
        converter = new UnitsConverter();
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0.45359237)]
    [InlineData(2.20462262185, 1)]
    [InlineData(5, 2.26796185)]
    public void PoundsToKilograms_ValidInput_ReturnsExpected(decimal pounds, decimal expected)
    {
        // Act
        var result = converter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expected, result, 10);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2.20462262185)]
    [InlineData(2.20462262185, 1)]
    [InlineData(5, 11.02311310925)]
    public void KilogramsToPounds_ValidInput_ReturnsExpected(decimal kilograms, decimal expected)
    {
        // Act
        var result = converter.KilogramsToPounds(kilograms);

        // Assert
        Assert.Equal(expected, result, 10);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2.54)]
    [InlineData(2.54, 6.4516)]
    [InlineData(5, 12.7)]
    public void InchesToCentimeters_ValidInput_ReturnsExpected(decimal inches, decimal expected)
    {
        // Act
        var result = converter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expected, result, 10);
    }

    [Theory]
    [InlineData(0, "0")]
    [InlineData(30.48, "1'")]
    [InlineData(91.44, "3'")]
    [InlineData(160.02, "5'3\"")]
    public void CentimetersToInches_ValidInput_ReturnsExpected(decimal centimeters, string expected)
    {
        // Act
        var result = converter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    [InlineData(37, 98.6)]
    public void CelsiusToFahrenheit_ValidInput_ReturnsExpected(decimal celsius, decimal expected)
    {
        // Act
        var result = converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expected, result, 10);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    [InlineData(98.6, 37)]
    public void FahrenheitToCelsius_ValidInput_ReturnsExpected(decimal fahrenheit, decimal expected)
    {
        // Act
        var result = converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expected, result, 10);
    }
}