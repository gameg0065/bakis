using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class StatOneTests
{
    [Theory]
    [InlineData(new double[] { 1, 2, 3 }, 0.66666666)]  
    [InlineData(new double[] { 10, 20, 30 }, 66.6666666)] 
    public void Variance_BasicCalculations_ShouldReturnCorrectly(double[] data, double expectedVariance)
    {
        var result = data.Variance();
        Assert.Equal(expectedVariance, result, 8); // Adjust precision as needed
    }

    [Fact]
    public void Variance_EmptyInput_ShouldReturnZero()
    {
        var data = new double[] { };
        var result = data.Variance();
        Assert.Equal(0, result);
    }

    [Fact]
    public void Covariance_IdenticalArrays_ShouldEqualVariance()
    {
        var data1 = new double[] { 2, 5, 9 };
        var data2 = new double[] { 2, 5, 9 };

        var covariance = StatOne.Covariance(data1, data2);
        var variance = data1.Variance(); // Or data2, they're the same

        Assert.Equal(variance, covariance);
    }

    [Fact]
    public void GetSlopeIntercept_SimpleData_ShouldCalculateCorrectly()
    {
        var x = new double[] { 1, 2, 3 };
        var y = new double[] { 3, 5, 7 };
        double yIntercept; 

        var slope = StatOne.GetSlopeIntercept(x, y, out yIntercept);

        Assert.Equal(2, slope); 
        Assert.Equal(1, yIntercept); 
    }
}