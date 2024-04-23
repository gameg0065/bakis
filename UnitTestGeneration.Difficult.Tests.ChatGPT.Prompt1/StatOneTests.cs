using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class StatOneTests
{
    [Fact]
    public void Variance_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] data = { 2, 4, 4, 4, 5, 5, 7, 9 };

        // Act
        double variance = StatOne.Variance(data);

        // Assert
        Assert.Equal(4.0, variance);
    }

    [Fact]
    public void StandardDeviation_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] data = { 2, 4, 4, 4, 5, 5, 7, 9 };

        // Act
        double stdDev = StatOne.StandardDeviation(data);

        // Assert
        Assert.Equal(2.0, stdDev);
    }

    [Fact]
    public void Correlation_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 6, 8, 10 };
        double[] other = { 1, 3, 5, 7, 9 };

        // Act
        double correlation = StatOne.Correlation(source, other);

        // Assert
        Assert.Equal(1.0, correlation); // Perfect positive correlation
    }

    [Fact]
    public void RSquared_ShouldCalculateCorrectly()
    {
        // Arrange
        double[] source = { 2, 4, 6, 8, 10 };
        double[] other = { 1, 3, 5, 7, 9 };

        // Act
        double rSquared = StatOne.RSquared(source, other);

        // Assert
        Assert.Equal(1.0, rSquared); // Perfect positive correlation
    }

    [Fact]
    public void Phi_ShouldCalculateCorrectly()
    {
        // Arrange
        double x = 0.5;

        // Act
        double phi = StatOne.Phi(x);

        // Assert
        Assert.Equal(0.69146246127401312, phi, 10); // Up to 10 decimal places
    }
}