using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class UnitsConverterTests
{
    private readonly UnitsConverter converter = new UnitsConverter();

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0.45359237)]
    [InlineData(10, 4.5359237)]
    [InlineData(100, 45.359237)]
    public void PoundsToKilograms_ReturnsExpectedResult(decimal pounds, decimal expected)
    {
        // Act
        decimal result = converter.PoundsToKilograms(pounds);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2.54)]
    [InlineData(10, 25.4)]
    [InlineData(100, 254)]
    public void InchesToCentimeters_ReturnsExpectedResult(decimal inches, decimal expected)
    {
        // Act
        decimal result = converter.InchesToCentimeters(inches);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void CelsiusToFahrenheit_ReturnsExpectedResult(decimal celsius, decimal expected)
    {
        // Act
        decimal result = converter.CelsiusToFahrenheit(celsius);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(-40, -40)]
    public void FahrenheitToCelsius_ReturnsExpectedResult(decimal fahrenheit, decimal expected)
    {
        // Act
        decimal result = converter.FahrenheitToCelsius(fahrenheit);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, "0")]
    [InlineData(30.48, "1'")]
    [InlineData(60.96, "2'")]
    [InlineData(182.88, "6'")]
    [InlineData(3048, "100'")]
    public void CentimetersToInches_ReturnsExpectedResult(decimal centimeters, string expected)
    {
        // Act
        string result = converter.CentimetersToInches(centimeters);

        // Assert
        Assert.Equal(expected, result);
    }
}