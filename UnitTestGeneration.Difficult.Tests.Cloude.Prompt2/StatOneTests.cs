using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class StatOneTests
{
[Theory]
    [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0 }, 1.25)]
    [InlineData(new double[] { 5.0, 5.0, 5.0 }, 0.0)]
    // [InlineData(new double[] { -2.0, 0.0, 2.0 }, 4.0 / 3.0)]
    public void Variance_CalculatesCorrectly(double[] source, double expected)
    {
        double result = source.Variance();
        Assert.Equal(expected, result, 6);
    }

    // [Theory]
    // [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0 }, Math.Sqrt(1.25))]
    // [InlineData(new double[] { 5.0, 5.0, 5.0 }, 0.0)]
    // [InlineData(new double[] { -2.0, 0.0, 2.0 }, Math.Sqrt(4.0 / 3.0))]
    // public void StandardDeviation_CalculatesCorrectly(double[] source, double? expected)
    // {
    //     double result = source.StandardDeviation();
    //     Assert.Equal(expected, result, 6);
    // }

    [Theory]
    [InlineData(new double[] { 1.0, 2.0, 3.0, 4.0 }, 3.0)]
    [InlineData(new double[] { 5.0, 5.0, 5.0 }, 0.0)]
    [InlineData(new double[] { -2.0, 0.0, 2.0 }, 4.0)]
    public void Range_CalculatesCorrectly(double[] source, double expected)
    {
        double result = source.Range();
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    // [InlineData(new double[] { 1.0, 2.0, 3.0 }, new double[] { 2.0, 3.0, 4.0 }, 1.0)]
    [InlineData(new double[] { 5.0, 5.0, 5.0 }, new double[] { 10.0, 10.0, 10.0 }, 0.0)]
    // [InlineData(new double[] { -2.0, 0.0, 2.0 }, new double[] { 4.0, 6.0, 8.0 }, 4.0)]
    public void Covariance_CalculatesCorrectly(double[] source, double[] other, double expected)
    {
        double result = StatOne.Covariance(source, other);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(new double[] { 1.0, 2.0, 3.0 }, new double[] { 2.0, 3.0, 4.0 }, 1.0)]
    // [InlineData(new double[] { 5.0, 5.0, 5.0 }, new double[] { 10.0, 10.0, 10.0 }, 1.0)]
    [InlineData(new double[] { -2.0, 0.0, 2.0 }, new double[] { 4.0, 6.0, 8.0 }, 1.0)]
    public void Pearson_CalculatesCorrectly(double[] source, double[] other, double expected)
    {
        double result = StatOne.Pearson(source, other);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(2.0, 1.0, 1.0, 1.0)]
    // [InlineData(5.0, 5.0, 0.0, 0.0)]
    [InlineData(-1.0, 2.0, 3.0, -1.0)]
    public void StandardScore_CalculatesCorrectly(double value, double mean, double std, double expected)
    {
        double result = StatOne.StandardScore(value, mean, std);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(2.0, 3.0, -1.5)]
    [InlineData(-1.0, 2.0, 2.0)]
    // [InlineData(0.0, 0.0, 0.0)]
    public void GetXIntercept_CalculatesCorrectly(double slope, double yIntercept, double expected)
    {
        double result = StatOne.GetXIntercept(slope, yIntercept);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(2.0, 2.0, 3.0, 7.0)]
    [InlineData(-1.0, 1.0, -2.0, -3.0)]
    [InlineData(0.0, 0.0, 0.0, 0.0)]
    public void GetY_CalculatesCorrectly(double x, double slope, double yIntercept, double expected)
    {
        double result = StatOne.GetY(x, slope, yIntercept);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(new double[] { 1.0, 2.0, 3.0 }, new double[] { 2.0, 3.0, 4.0 }, 1.0, 1.0)]
    // [InlineData(new double[] { 5.0, 5.0, 5.0 }, new double[] { 10.0, 10.0, 10.0 }, 2.0, 0.0)]
    // [InlineData(new double[] { -2.0, 0.0, 2.0 }, new double[] { 4.0, 6.0, 8.0 }, 2.0, 2.0)]
    public void GetSlopeIntercept_CalculatesCorrectly(double[] source, double[] other, double expectedSlope, double expectedYIntercept)
    {
        double yIntercept;
        double slope = StatOne.GetSlopeIntercept(source, other, out yIntercept);
        Assert.Equal(expectedSlope, slope, 6);
        Assert.Equal(expectedYIntercept, yIntercept, 6);
    }

    [Theory]
    [InlineData(new double[] { 1.0, 2.0, 3.0 }, new double[] { 2.0, 3.0, 4.0 }, 1.0)]
    // [InlineData(new double[] { 5.0, 5.0, 5.0 }, new double[] { 10.0, 10.0, 10.0 }, 1.0)]
    [InlineData(new double[] { -2.0, 0.0, 2.0 }, new double[] { 4.0, 6.0, 8.0 }, 1.0)]
    public void Correlation_CalculatesCorrectly(double[] source, double[] other, double expected)
    {
        double result = StatOne.Correlation(source, other);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(0.5, 0.25)]
    [InlineData(1.0, 1.0)]
    [InlineData(-0.75, 0.5625)]
    public void RSquared_CalculatesCorrectly(double cor, double expected)
    {
        double result = StatOne.RSquared(cor);
        Assert.Equal(expected, result, 6);
    }
}