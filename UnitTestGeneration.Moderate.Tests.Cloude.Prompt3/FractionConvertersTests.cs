using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class FractionConvertersTests
{
  [Fact]
    public void SafeDivision_ValidInputs_ReturnsCorrectResult()
    {
        // Arrange
        decimal numerator = 10;
        decimal denominator = 5;
        decimal expected = 2;

        // Act
        decimal result = FractionConverters.SafeDivision(numerator, denominator);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SafeDivision_NumeratorIsZero_ThrowsDivideByZeroException()
    {
        // Arrange
        decimal numerator = 0;
        decimal denominator = 5;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Fact]
    public void SafeDivision_DenominatorIsZero_ThrowsDivideByZeroException()
    {
        // Arrange
        decimal numerator = 10;
        decimal denominator = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Theory]
    [InlineData("1/2", 0.5)]
    [InlineData("3/4", 0.75)]
    [InlineData("0/5", 0)]
    [InlineData("10/1", 10)]
    public void Fraction_ValidInputs_ReturnsCorrectResult(string fracTxt, decimal expected)
    {
        // Arrange
        var converters = new FractionConverters();

        // Act
        decimal result = converters.Fraction(fracTxt);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fraction_DenominatorIsZero_WritesErrorMessage()
    {
        // Arrange
        var converters = new FractionConverters();
        string fracTxt = "1/0";

        // Act & Assert
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        converters.Fraction(fracTxt);
        Assert.Contains("Attempted to write by zero.", consoleOutput.ToString());
    }

    [Theory]
    [InlineData("5'6", 66)]
    [InlineData("0'0", 0)]
    [InlineData("10'11", 131)]
    public void InchesSplit_ValidInputs_ReturnsCorrectResult(string inchesTxt, decimal expected)
    {
        // Arrange
        var converters = new FractionConverters();

        // Act
        decimal result = converters.InchesSplit(inchesTxt);

        // Assert
        Assert.Equal(expected, result);
    }
}