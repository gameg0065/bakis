using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt3;

public class EigenvalueTests
{
    [Fact]
    public void Dot_ValidVectors_CalculatesCorrectly()
    {
        double[] lhs = { 2, 3, -1 };
        double[] rhs = { 5, 1, 4 };
        double expected = 13; 

        double result = lhs.Dot(rhs);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Dot_MismatchedDimensions_ThrowsException()
    {
        double[] lhs = { 1, 2 };
        double[] rhs = { 1, 2, 3 }; 

        Assert.Throws<ArgumentException>(() => lhs.Dot(rhs));
    }

    // [Fact]
    // public void Dominant_SmallMatrix_CalculatesCorrectly()
    // {
    //     double[,] matrix = { { 2, 1 }, { 1, 3 } };
    //     double[] startVector = { 1, 1 };
    //     double errorTolerance = 0.01; // Adjust if needed
    //
    //     (double eigenvalue, double[] eigenvector) = matrix.Dominant(startVector, errorTolerance);
    //
    //     // Assert that eigenvalue and eigenvector are close to expected values 
    //     // (you'd need to calculate the true values beforehand)
    // } 
}