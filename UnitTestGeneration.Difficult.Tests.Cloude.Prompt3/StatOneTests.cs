using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class StatOneTests
{
[Fact]
    public void Variance_SingleElement_ReturnsZero()
    {
        double[] source = { 5 };
        double expected = 0;
        double actual = source.Variance();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Variance_EmptyArray_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => source.Variance());
    }

    [Fact]
    public void StandardDeviation_SingleElement_ReturnsZero()
    {
        double[] source = { 5 };
        double expected = 0;
        double actual = source.StandardDeviation();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StandardDeviation_EmptyArray_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => source.StandardDeviation());
    }

    [Fact]
    public void Range_EmptyArray_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => source.Range());
    }

    [Fact]
    public void Range_SingleElement_ReturnsZero()
    {
        double[] source = { 5 };
        double expected = 0;
        double actual = source.Range();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Covariance_DifferentLengths_ThrowsException()
    {
        double[] source = { 1, 2, 3 };
        double[] other = { 4, 5 };
        Assert.Throws<InvalidOperationException>(() => StatOne.Covariance(source, other));
    }

    [Fact]
    public void Covariance_EmptyArrays_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        double[] other = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => StatOne.Covariance(source, other));
    }

    [Fact]
    public void Pearson_DifferentLengths_ThrowsException()
    {
        double[] source = { 1, 2, 3 };
        double[] other = { 4, 5 };
        Assert.Throws<InvalidOperationException>(() => StatOne.Pearson(source, other));
    }

    [Fact]
    public void Pearson_EmptyArrays_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        double[] other = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => StatOne.Pearson(source, other));
    }

    [Fact]
    public void StandardScore_PositiveValues()
    {
        double value = 10;
        double mean = 5;
        double std = 2;
        double expected = 2.5;
        double actual = StatOne.StandardScore(value, mean, std);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StandardScore_NegativeValues()
    {
        double value = -5;
        double mean = 10;
        double std = 3;
        double expected = -5;
        double actual = StatOne.StandardScore(value, mean, std);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetXIntercept_PositiveSlope()
    {
        double slope = 2;
        double yIntercept = 4;
        double expected = -2;
        double actual = StatOne.GetXIntercept(slope, yIntercept);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetXIntercept_NegativeSlope()
    {
        double slope = -3;
        double yIntercept = 6;
        double expected = -2;
        double actual = StatOne.GetXIntercept(slope, yIntercept);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetY_PositiveValues()
    {
        double x = 2;
        double slope = 3;
        double yIntercept = 1;
        double expected = 7;
        double actual = StatOne.GetY(x, slope, yIntercept);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetY_NegativeValues()
    {
        double x = -1;
        double slope = -2;
        double yIntercept = 4;
        double expected = 6;
        double actual = StatOne.GetY(x, slope, yIntercept);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetSlopeIntercept_DifferentLengths_ThrowsException()
    {
        double[] source = { 1, 2, 3 };
        double[] other = { 4, 5 };
        double yIntercept;
        Assert.Throws<InvalidOperationException>(() => StatOne.GetSlopeIntercept(source, other, out yIntercept));
    }

    [Fact]
    public void GetSlopeIntercept_EmptyArrays_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        double[] other = Array.Empty<double>();
        double yIntercept;
        Assert.Throws<InvalidOperationException>(() => StatOne.GetSlopeIntercept(source, other, out yIntercept));
    }

    [Fact]
    public void Correlation_DifferentLengths_ThrowsException()
    {
        double[] source = { 1, 2, 3 };
        double[] other = { 4, 5 };
        Assert.Throws<InvalidOperationException>(() => StatOne.Correlation(source, other));
    }

    [Fact]
    public void Correlation_EmptyArrays_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        double[] other = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => StatOne.Correlation(source, other));
    }

    [Fact]
    public void RSquared_PositiveCorrelation()
    {
        double cor = 0.8;
        double expected = 0.64;
        double actual = StatOne.RSquared(cor);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RSquared_NegativeCorrelation()
    {
        double cor = -0.6;
        double expected = 0.36;
        double actual = StatOne.RSquared(cor);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RSquared_Arrays_DifferentLengths_ThrowsException()
    {
        double[] source = { 1, 2, 3 };
        double[] other = { 4, 5 };
        Assert.Throws<InvalidOperationException>(() => StatOne.RSquared(source, other));
    }

    [Fact]
    public void RSquared_Arrays_EmptyArrays_ThrowsException()
    {
        double[] source = Array.Empty<double>();
        double[] other = Array.Empty<double>();
        Assert.Throws<InvalidOperationException>(() => StatOne.RSquared(source, other));
    }
}