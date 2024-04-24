using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class UnitsConverterTests
{
private readonly UnitsConverter _converter;

    public UnitsConverterTests()
    {
        _converter = new UnitsConverter();
    }

    [Fact]
    public void PoundsToKilograms_ReturnsCorrectValue()
    {
        // Arrange
        decimal pounds = 10;
        decimal expected = 4.53592370616839m;

        // Act
        decimal result = _converter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void KilogramsToPounds_ReturnsCorrectValue()
    {
        // Arrange
        decimal kilograms = 5;
        decimal expected = 11.0231131092425m;

        // Act
        decimal result = _converter.KilogramsToPounds(kilograms);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void InchesToCentimeters_ReturnsCorrectValue()
    {
        // Arrange
        decimal inches = 10;
        decimal expected = 25.4m;

        // Act
        decimal result = _converter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(30.48, "2'6")]
    [InlineData(12.7, "5")]
    public void CentimetersToInches_ReturnsCorrectValue(decimal centimeters, string expected)
    {
        // Act
        string result = _converter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CelsiusToFahrenheit_ReturnsCorrectValue()
    {
        // Arrange
        decimal celsius = 20;
        decimal expected = 68m;

        // Act
        decimal result = _converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FahrenheitToCelsius_ReturnsCorrectValue()
    {
        // Arrange
        decimal fahrenheit = 68;
        decimal expected = 20m;

        // Act
        decimal result = _converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expected, result);
    }
}