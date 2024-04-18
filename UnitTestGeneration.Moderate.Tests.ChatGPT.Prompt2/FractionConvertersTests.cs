using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class FractionConvertersTests
{
    [Theory]
    [InlineData("2/0")]
    [InlineData("0/5")]
    public void Fraction_ThrowsException_ForDivisionByZero(string fraction)
    {
        // Arrange
        var fractionConverter = new FractionConverters();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => fractionConverter.Fraction(fraction));
    }

    [Theory]
    [InlineData("1/4", 0.25)]
    [InlineData("3/8", 0.375)]
    [InlineData("5/2", 2.5)]
    public void Fraction_ReturnsCorrectResult_ForValidInput(string fraction, decimal expected)
    {
        // Arrange
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.Fraction(fraction);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("5'6\"", 66)]
    [InlineData("2'0\"", 24)]
    [InlineData("3'9\"", 45)]
    public void InchesSplit_ReturnsCorrectResult_ForValidInput(string inchesTxt, decimal expected)
    {
        // Arrange
        var fractionConverter = new FractionConverters();

        // Act
        decimal result = fractionConverter.InchesSplit(inchesTxt);

        // Assert
        Assert.Equal(expected, result);
    }
}