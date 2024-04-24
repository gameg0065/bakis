using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class StatOneTests
{
    [Fact]
    public void Variance_ShouldCalculateVarianceCorrectly()
    {
        // Arrange
        double[] data = { 1, 2, 3, 4, 5 };
        double expected = 2.5;

        // Act
        double result = data.Variance();

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void StandardDeviation_ShouldCalculateStandardDeviationCorrectly()
    {
        // Arrange
        double[] data = { 1, 2, 3, 4, 5 };
        double expected = Math.Sqrt(2.5);

        // Act
        double result = data.StandardDeviation();

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void Range_ShouldCalculateRangeCorrectly()
    {
        // Arrange
        IEnumerable<double> data = new[] { 1.0, 2.5, 3.7, 4.2, 5.0 };
        double expected = 4.0;

        // Act
        double result = data.Range();

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void Covariance_ShouldCalculateCovarianceCorrectly()
    {
        // Arrange
        double[] data1 = { 1, 2, 3, 4, 5 };
        double[] data2 = { 2, 4, 6, 8, 10 };
        double expected = 2.5;

        // Act
        double result = StatOne.Covariance(data1, data2);

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void Pearson_ShouldCalculatePearsonCorrelationCorrectly()
    {
        // Arrange
        double[] data1 = { 1, 2, 3, 4, 5 };
        double[] data2 = { 2, 4, 6, 8, 10 };
        double expected = 1.0;

        // Act
        double result = StatOne.Pearson(data1, data2);

        // Assert
        Assert.Equal(expected, result, 6);
    }
}