using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class UnitsConverterTests
{
    
[Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0.453592)]
    [InlineData(10, 4.53592)]
    [InlineData(100, 45.3592)]
    public void PoundsToKilograms_ReturnsCorrectResult(decimal pounds, decimal expectedKilograms)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        decimal result = unitsConverter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expectedKilograms, result, 5); // Allow a small difference due to decimal precision
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0.453592)]
    [InlineData(10, 4.53592)]
    [InlineData(100, 45.3592)]
    public void KilogramsToPounds_ReturnsCorrectResult(decimal kilograms, decimal expectedPounds)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        decimal result = unitsConverter.KilogramsToPounds(kilograms);

        // Assert
        Assert.Equal(expectedPounds, result, 5); // Allow a small difference due to decimal precision
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2.54)]
    [InlineData(10, 25.4)]
    [InlineData(100, 254)]
    public void InchesToCentimeters_ReturnsCorrectResult(decimal inches, decimal expectedCentimeters)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        decimal result = unitsConverter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expectedCentimeters, result);
    }

    [Theory]
    [InlineData(0, "0")]
    [InlineData(2.54, "1")]
    [InlineData(25.4, "10")]
    [InlineData(254, "100")]
    [InlineData(304.8, "1'")]
    [InlineData(609.6, "2'")]
    [InlineData(914.4, "3'")]
    public void CentimetersToInches_ReturnsCorrectResult(decimal centimeters, string expectedInches)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        string result = unitsConverter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expectedInches, result);
    }

    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void CelsiusToFahrenheit_ReturnsCorrectResult(decimal celsius, decimal expectedFahrenheit)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        decimal result = unitsConverter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expectedFahrenheit, result);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    public void FahrenheitToCelsius_ReturnsCorrectResult(decimal fahrenheit, decimal expectedCelsius)
    {
        // Arrange
        var unitsConverter = new UnitsConverter();

        // Act
        decimal result = unitsConverter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expectedCelsius, result);
    }
}