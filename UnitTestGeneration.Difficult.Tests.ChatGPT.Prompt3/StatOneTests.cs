using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class StatOneTests
{
    [Fact]
    public void Variance_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 4, 4, 5, 5, 7, 9 };

        // Act
        double result = StatOne.Variance(source);

        // Assert
        Assert.Equal(4.0, result);
    }

    [Fact]
    public void StandardDeviation_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 4, 4, 5, 5, 7, 9 };

        // Act
        double result = StatOne.StandardDeviation(source);

        // Assert
        Assert.Equal(2.0, result);
    }

    [Fact]
    public void Range_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 4, 4, 5, 5, 7, 9 };

        // Act
        double result = StatOne.Range(source);

        // Assert
        Assert.Equal(7.0, result);
    }

    [Fact]
    public void Covariance_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 4, 4, 5 };
        double[] other = { 3, 5, 5, 5, 6 };

        // Act
        double result = StatOne.Covariance(source, other);

        // Assert
        Assert.Equal(0.7, result);
    }

    [Fact]
    public void Pearson_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 4, 4, 5 };
        double[] other = { 3, 5, 5, 5, 6 };

        // Act
        double result = StatOne.Pearson(source, other);

        // Assert
        Assert.Equal(0.9258200997725514, result, 14);
    }

    // Similar tests for other methods would follow
}