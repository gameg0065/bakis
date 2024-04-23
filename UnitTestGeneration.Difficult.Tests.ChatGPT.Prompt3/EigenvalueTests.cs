using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class EigenvalueTests
{
[Fact]
    public void Dot_ShouldCalculateDotProductCorrectly()
    {
        // Arrange
        double[] vector1 = { 1, 2, 3 };
        double[] vector2 = { 4, 5, 6 };

        // Act
        var dotProduct = Eigenvalue.Dot(vector1, vector2);

        // Assert
        Assert.Equal(32, dotProduct);
    }

    [Fact]
    public void Magnitude_ShouldCalculateMagnitudeCorrectly()
    {
        // Arrange
        double[] vector = { 3, 4 };

        // Act
        var magnitude = Eigenvalue.Magnitude(vector);

        // Assert
        Assert.Equal(5, magnitude);
    }

    [Fact]
    public void ToColumnVector_ShouldConvertToColumnVectorCorrectly()
    {
        // Arrange
        double[] vector = { 1, 2, 3 };

        // Act
        var columnVector = Eigenvalue.ToColumnVector(vector);

        // Assert
        Assert.Equal(3, columnVector.GetLength(0));
        Assert.Equal(1, columnVector.GetLength(1));
        Assert.Equal(1, columnVector[0, 0]);
        Assert.Equal(2, columnVector[1, 0]);
        Assert.Equal(3, columnVector[2, 0]);
    }

    [Fact]
    public void ToRowVector_ShouldConvertToRowVectorCorrectly()
    {
        // Arrange
        double[,] columnVector = { { 1 }, { 2 }, { 3 } };

        // Act
        var rowVector = Eigenvalue.ToRowVector(columnVector);

        // Assert
        Assert.Equal(3, rowVector.Length);
        Assert.Equal(1, rowVector[0]);
        Assert.Equal(2, rowVector[1]);
        Assert.Equal(3, rowVector[2]);
    }

    [Fact]
    public void Multiply_ShouldMultiplyMatricesCorrectly()
    {
        // Arrange
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        double[,] expected = { { 19, 22 }, { 43, 50 } };

        // Act
        var result = Eigenvalue.Multiply(matrix1, matrix2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Dominant_ShouldFindDominantEigenvalueAndEigenvectorCorrectly()
    {
        // Arrange
        double[,] matrix = { { 1, 2 }, { 2, 1 } };
        double[] startVector = { 1, 1 };
        double expectedEigenvalue = 3.0;
        double[] expectedEigenvector = { 1 / Math.Sqrt(2), 1 / Math.Sqrt(2) };

        // Act
        var (eigenvalue, eigenvector) = Eigenvalue.Dominant(matrix, startVector);

        // Assert
        Assert.Equal(expectedEigenvalue, eigenvalue, 5);
        Assert.Equal(expectedEigenvector, eigenvector, new DoubleArrayComparer());
    }
}

public class DoubleArrayComparer : IEqualityComparer<double[]>
{
    public bool Equals(double[] x, double[] y)
    {
        return x.SequenceEqual(y);
    }

    public int GetHashCode(double[] obj)
    {
        return obj.GetHashCode();
    }
}