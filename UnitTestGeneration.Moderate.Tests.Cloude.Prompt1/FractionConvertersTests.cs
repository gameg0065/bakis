using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class FractionConvertersTests
{
    [Fact]
    public void SafeDivision_ValidInput_ReturnsCorrectResult()
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
    public void SafeDivision_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        decimal numerator = 10;
        decimal denominator = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Theory]
    [InlineData("2/8", 0.25)]
    [InlineData("3/4", 0.75)]
    [InlineData("5/1", 5)]
    public void Fraction_ValidInput_ReturnsCorrectResult(string fracTxt, decimal expected)
    {
        // Arrange
        FractionConverters converter = new FractionConverters();

        // Act
        decimal result = converter.Fraction(fracTxt);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fraction_DivideByZero_DoesNotThrowException()
    {
        // Arrange
        FractionConverters converter = new FractionConverters();
        string fracTxt = "2/0";

        // Act & Assert
        converter.Fraction(fracTxt); // No exception should be thrown
    }

    [Theory]
    [InlineData("5'6", 66)]
    [InlineData("0'10", 10)]
    [InlineData("1'0", 12)]
    public void InchesSplit_ValidInput_ReturnsCorrectResult(string inchesTxt, decimal expected)
    {
        // Arrange
        FractionConverters converter = new FractionConverters();

        // Act
        decimal result = converter.InchesSplit(inchesTxt);

        // Assert
        Assert.Equal(expected, result);
    }
}