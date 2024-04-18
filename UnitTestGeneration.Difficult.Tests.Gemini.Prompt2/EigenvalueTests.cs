using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class EigenvalueTests
{
    [Fact]
    public void Dot_EqualLengthVectors_ReturnsDotProduct()
    {
        double[] lhs = { 2, 3, 1 };
        double[] rhs = { 4, 1, 5 };
        double expected = 16;

        double result = lhs.Dot(rhs);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Dot_UnequalLengths_ThrowsException()
    {
        double[] lhs = { 2, 3, 1 };
        double[] rhs = { 4, 1 };

        Assert.Throws<ArgumentException>(() => lhs.Dot(rhs));
    }

    [Fact]
    public void Magnitude_CalculatesCorrectly()
    {
        double[] vector = { 3, 4, 0 };
        double expected = 5;

        double result = vector.Magnitude();
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_CalculatesMatrixProduct()
    {
        double[,] matrix1 = { { 1, 2 }, 
            { 3, 4 } };
        double[,] matrix2 = { { 0, 5 }, 
            { 1, 6 } };
        double[,] expected = { { 2, 17 }, 
            { 4, 39 } };

        var result = matrix1.Multiply(matrix2);
        Assert.Equal(expected, result); // Element-wise comparison
    }

    // [Fact]
    // public void Multiply_InvalidDimensions_ThrowsException()
    // {
    //     // ... set up matrices with mismatched dimensions
    //     Assert.Throws<InvalidOperationException>(() => matrix1.Multiply(matrix2));
    // }

}