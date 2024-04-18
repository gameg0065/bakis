using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class EigenvalueTests
{
    [Fact]
    public void Dot_CalculatesCorrectly()
    {
        double[] lhs = { 1, 2, 3 };
        double[] rhs = { 4, 5, 6 };

        var result = lhs.Dot(rhs);

        Assert.Equal(32, result); 
    }

    [Fact]
    public void Dot_MismatchedDimensions_ThrowsException()
    {
        double[] lhs = { 1, 2 };
        double[] rhs = { 3, 4, 5};

        Assert.Throws<ArgumentException>(() => lhs.Dot(rhs));
    }

    // Tests for Magnitude, ToRowVector, ToColumnVector 
    // ... (Similar Structure)

    // Tests for Multiply
    [Fact]
    public void Multiply_CalculatesCorrectly()
    {
        double[,] matrixA = 
        {
            { 1, 2 },
            { 3, 4 }
        };

        double[,] matrixB = 
        {
            { 5, 6 },
            { 7, 8 }
        };

        double[,] expected = 
        {
            { 19, 22 },
            { 43, 50 }
        };

        var result = matrixA.Multiply(matrixB); 
        Assert.Equal(expected, result); 
    }

    // ... Tests for Multiply with invalid dimensions

    // // Tests for Dominant
    // [Fact]
    // public void Dominant_CalculatesKnownEigenvalueEigenvector()
    // {
    //     double[,] matrix = 
    //     {
    //         { 2, 1 },
    //         { 1, 2 }
    //     }; 
    //
    //     // You'll need the known eigenvalue and eigenvector 
    //     // for this matrix to compare against.
    //
    //     (double eigenvalue, double[] eigenvector) = matrix.Dominant();
    //
    //     // Assert eigenvalue is close to the expected value (with some tolerance)
    //     // Assert eigenvector components are close to expected (with tolerance) 
    // }
}