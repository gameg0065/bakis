using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class FractionConvertersTests
{
    [Theory]
    [InlineData("2/8", 0.25)]
    [InlineData("1/2", 0.5)]
    [InlineData("5/10", 0.5)]
    public void Fraction_ValidInput_ReturnsExpectedResult(string input, decimal expected)
    {
        // Arrange
        var fractionConverter = new FractionConverters();

        // Act
        var result = fractionConverter.Fraction(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fraction_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var fractionConverter = new FractionConverters();
        string input = "5/0";

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => fractionConverter.Fraction(input));
    }

    [Theory]
    [InlineData("5'6", 66)]
    [InlineData("10'0", 120)]
    public void InchesSplit_ValidInput_ReturnsExpectedResult(string input, decimal expected)
    {
        // Arrange
        var fractionConverter = new FractionConverters();

        // Act
        var result = fractionConverter.InchesSplit(input);

        // Assert
        Assert.Equal(expected, result);
    }
}