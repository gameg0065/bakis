using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class StatOneTests
{
    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4, 5 }, 2.5)]
    [InlineData(new double[] { -1, -2, -3, -4, -5 }, 2.5)]
    [InlineData(new double[] { 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new double[] { 10, 20, 30, 40, 50 }, 200)]
    public void Variance_ShouldCalculateCorrectly(double[] values, double expected)
    {
        // Act
        var result = StatOne.Variance(values);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4, 5 }, 1.5811388300841898)]
    [InlineData(new double[] { -1, -2, -3, -4, -5 }, 1.5811388300841898)]
    [InlineData(new double[] { 0, 0, 0, 0, 0 }, 0)]
    [InlineData(new double[] { 10, 20, 30, 40, 50 }, 15.811388300841896)]
    public void StandardDeviation_ShouldCalculateCorrectly(double[] values, double expected)
    {
        // Act
        var result = StatOne.StandardDeviation(values);

        // Assert
        Assert.Equal(expected, result);
    }

}