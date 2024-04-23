using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class EigenvalueTests
{
[Fact]
    public void Dot_ShouldCalculateDotProduct_WhenGivenTwoVectors()
    {
        // Arrange
        double[] vector1 = { 1, 2, 3 };
        double[] vector2 = { 4, 5, 6 };

        // Act
        double result = Eigenvalue.Dot(vector1, vector2);

        // Assert
        Assert.Equal(32, result);
    }

    [Fact]
    public void Magnitude_ShouldCalculateMagnitude_WhenGivenVector()
    {
        // Arrange
        double[] vector = { 3, 4 };

        // Act
        double result = Eigenvalue.Magnitude(vector);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void ToColumnVector_ShouldConvertArrayToColumnVector_WhenGivenArray()
    {
        // Arrange
        double[] array = { 1, 2, 3 };

        // Act
        double[,] result = Eigenvalue.ToColumnVector(array);

        // Assert
        Assert.Equal(3, result.GetLength(0));
        Assert.Equal(1, result.GetLength(1));
        Assert.Equal(1, result[0, 0]);
        Assert.Equal(2, result[1, 0]);
        Assert.Equal(3, result[2, 0]);
    }

    [Fact]
    public void ToRowVector_ShouldConvertColumnVectorToRowVector_WhenGivenColumnVector()
    {
        // Arrange
        double[,] columnVector = { { 1 }, { 2 }, { 3 } };

        // Act
        double[] result = Eigenvalue.ToRowVector(columnVector);

        // Assert
        Assert.Equal(3, result.Length);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
        Assert.Equal(3, result[2]);
    }

    [Fact]
    public void Multiply_ShouldMultiplyMatrices_WhenGivenTwoMatrices()
    {
        // Arrange
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        // Act
        double[,] result = Eigenvalue.Multiply(matrix1, matrix2);

        // Assert
        Assert.Equal(19, result[0, 0]);
        Assert.Equal(22, result[0, 1]);
        Assert.Equal(43, result[1, 0]);
        Assert.Equal(50, result[1, 1]);
    }

    [Fact]
    public void Dominant_ShouldFindDominantEigenvalueAndEigenvector_WhenGivenMatrixAndStartVector()
    {
        // Arrange
        double[,] matrix = { { 2, 1 }, { 1, 3 } };
        double[] startVector = { 1, 0 };

        // Act
        var result = Eigenvalue.Dominant(matrix, startVector);

        // Assert
        Assert.Equal(3, result.eigenvalue, 5);
        // Assert.Equal(new[] { 1, 0 }, result.eigenvector);
    }

    [Fact]
    public void NextVector_ShouldGenerateRandomNormalizedVector_WhenGivenSize()
    {
        // Arrange
        var rand = new Random();

        // Act
        var result = rand.NextVector(3);

        // Assert
        Assert.Equal(1, result.Magnitude(), 5);
    }
}