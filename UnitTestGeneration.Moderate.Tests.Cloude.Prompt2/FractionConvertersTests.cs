using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class FractionConvertersTests
{
  [Fact]
    public void SafeDivision_NonZeroInputs_ReturnsQuotient()
    {
        // Arrange
        decimal numerator = 10;
        decimal denominator = 2;
        decimal expected = 5;

        // Act
        decimal result = FractionConverters.SafeDivision(numerator, denominator);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SafeDivision_NumeratorZero_ThrowsDivideByZeroException()
    {
        // Arrange
        decimal numerator = 0;
        decimal denominator = 2;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Fact]
    public void SafeDivision_DenominatorZero_ThrowsDivideByZeroException()
    {
        // Arrange
        decimal numerator = 10;
        decimal denominator = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Theory]
    [InlineData("2/8", 0.25)]
    [InlineData("1/3", 0.3333333333333333)]
    [InlineData("0/5", 0)]
    public void Fraction_ValidInput_ReturnsSimplifiedFraction(string fracTxt, decimal expected)
    {
        // Arrange
        var converter = new FractionConverters();

        // Act
        decimal result = converter.Fraction(fracTxt);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fraction_DenominatorZero_WritesErrorMessage()
    {
        // Arrange
        var converter = new FractionConverters();
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        converter.Fraction("2/0");

        // Assert
        string expectedOutput = "Attempted to write by zero.";
        Assert.Contains(expectedOutput, consoleOutput.ToString());
    }

    [Theory]
    [InlineData("66'8.88", 804.88)]
    [InlineData("0'0", 0)]
    [InlineData("12'0", 144)]
    public void InchesSplit_ValidInput_ReturnsInchesValue(string inchesTxt, decimal expected)
    {
        // Arrange
        var converter = new FractionConverters();

        // Act
        decimal result = converter.InchesSplit(inchesTxt);

        // Assert
        Assert.Equal(expected, result);
    }
}