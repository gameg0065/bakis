using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class StatOneTests
{
    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4 }, 1.25)] // Simple dataset
    [InlineData(new double[] { 100, 105, 97 }, 12.33, 2)] // Larger values, specify precision
    [InlineData(new double[] { 0, 0, 0, 0 }, 0)] // All values the same
    public void Variance_CalculatesCorrectly(double[] data, double expected, int precision = -1)
    {
        var result = data.Variance();

        if (precision >= 0)
        {
            Assert.Equal(expected, result, precision); // Assert with specified precision
        }
        else
        {
            Assert.Equal(expected, result);
        }
    }
}