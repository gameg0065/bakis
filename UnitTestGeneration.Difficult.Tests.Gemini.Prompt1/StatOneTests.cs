using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class StatOneTests
{
    // Tests for Variance
    [Fact]
    public void Variance_CalculatesCorrectly()
    {
        double[] data = { 1, 2, 3, 4, 5 };
        double expectedVariance = 2.5; 

        var result = data.Variance();

        Assert.Equal(expectedVariance, result, 4); // Adjust precision as needed
    }

    [Fact]
    public void Variance_EmptyArray_ThrowsException()
    {
        double[] data = new double[] {};

        Assert.Throws<InvalidOperationException>(() => data.Variance()); 
    }

    // Tests for StandardDeviation
    [Fact]
    public void StandardDeviation_CalculatesCorrectly()
    {
        double[] data = { 2, 4, 4, 4, 5, 5, 7, 9 };
        double expectedStdDev = 2;

        var result = data.StandardDeviation();
        Assert.Equal(expectedStdDev, result, 4);  
    }

    // ... Add tests for the rest of your functions: Range, Covariance, Pearson, etc.

    // // Tests for helper functions 
    // [Theory]
    // [InlineData(5, 10, 2, -2)] // Example values
    // public void GetXIntercept_CalculatesCorrectly(double slope, double yIntercept, double expected)
    // {
    //     var result = StatOne.GetXIntercept(slope, yIntercept); 
    //     Assert.Equal(expected, result); 
    // }
}