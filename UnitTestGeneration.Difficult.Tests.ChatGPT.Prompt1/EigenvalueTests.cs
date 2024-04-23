using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt1;

public class EigenvalueTests
{
[Fact]
    public void Dot_ShouldCalculateDotProduct_Correctly()
    {
        // Arrange
        double[] vector1 = { 1, 2, 3 };
        double[] vector2 = { 4, 5, 6 };
        double expectedDotProduct = 32;

        // Act
        double result = Eigenvalue.Dot(vector1, vector2);

        // Assert
        Assert.Equal(expectedDotProduct, result);
    }

    [Fact]
    public void Magnitude_ShouldCalculateMagnitude_Correctly()
    {
        // Arrange
        double[] vector = { 3, 4 };
        double expectedMagnitude = 5;

        // Act
        double result = Eigenvalue.Magnitude(vector);

        // Assert
        Assert.Equal(expectedMagnitude, result);
    }

    [Fact]
    public void ToColumnVector_ShouldConvertToArrayWithOneColumn()
    {
        // Arrange
        double[] source = { 1, 2, 3 };
        double[,] expectedColumnVector = { { 1 }, { 2 }, { 3 } };

        // Act
        double[,] result = Eigenvalue.ToColumnVector(source);

        // Assert
        Assert.Equal(expectedColumnVector, result);
    }

    [Fact]
    public void ToRowVector_ShouldConvertToArrayWithOneRow()
    {
        // Arrange
        double[,] source = { { 1 }, { 2 }, { 3 } };
        double[] expectedRowVector = { 1, 2, 3 };

        // Act
        double[] result = Eigenvalue.ToRowVector(source);

        // Assert
        Assert.Equal(expectedRowVector, result);
    }

    [Fact]
    public void Multiply_ShouldMultiplyMatrices_Correctly()
    {
        // Arrange
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        double[,] expectedProduct = { { 19, 22 }, { 43, 50 } };

        // Act
        double[,] result = Eigenvalue.Multiply(matrix1, matrix2);

        // Assert
        Assert.Equal(expectedProduct, result);
    }

    [Fact]
    public void Dominant_ShouldFindDominantEigenvalueAndEigenvector()
    {
        // Arrange
        double[,] source = { { 2, -1 }, { -1, 2 } };
        double[] startVector = { 1, 1 };
        double expectedEigenvalue = 3.0;
        double[] expectedEigenvector = { 0.707106781186547, 0.707106781186547 };

        // Act
        var (eigenvalue, eigenvector) = Eigenvalue.Dominant(source, startVector);

        // Assert
        Assert.Equal(expectedEigenvalue, eigenvalue, 5);
        // Assert.Equal(expectedEigenvector, eigenvector, 5);
    }
}