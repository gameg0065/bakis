using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class FractionConvertersTests
{
    [Fact]
    public void SafeDivision_ReturnsCorrectResult_WhenDividingByNonZeroDenominator()
    {
        // Arrange
        decimal numerator = 4;
        decimal denominator = 2;

        // Act
        decimal result = FractionConverters.SafeDivision(numerator, denominator);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void SafeDivision_ThrowsDivideByZeroException_WhenDenominatorIsZero()
    {
        // Arrange
        decimal numerator = 4;
        decimal denominator = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => FractionConverters.SafeDivision(numerator, denominator));
    }

    [Fact]
    public void Fraction_ReturnsCorrectResult_WhenInputIsValidFraction()
    {
        // Arrange
        string fraction = "2/8";
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.Fraction(fraction);

        // Assert
        Assert.Equal(0.25m, result);
    }

    [Fact]
    public void InchesSplit_ReturnsCorrectResult_WhenInputIsValidInches()
    {
        // Arrange
        string inches = "5'6";
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.InchesSplit(inches);

        // Assert
        Assert.Equal(66m, result);
    }

    [Fact]
    public void InchesSplit_ReturnsCorrectResult_WhenInputHasNoFeet()
    {
        // Arrange
        string inches = "0'6";
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.InchesSplit(inches);

        // Assert
        Assert.Equal(6m, result);
    }

    [Fact]
    public void InchesSplit_ReturnsCorrectResult_WhenInputHasNoInches()
    {
        // Arrange
        string inches = "5'0";
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.InchesSplit(inches);

        // Assert
        Assert.Equal(60m, result);
    }
}