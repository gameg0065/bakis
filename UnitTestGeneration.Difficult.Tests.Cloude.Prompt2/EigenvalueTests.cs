using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class EigenvalueTests
{
[Fact]
    public void Dot_SameVectors_ReturnsCorrectResult()
    {
        // Arrange
        var vector1 = new[] { 1.0, 2.0, 3.0 };
        var vector2 = new[] { 1.0, 2.0, 3.0 };

        // Act
        var result = Eigenvalue.Dot(vector1, vector2);

        // Assert
        Assert.Equal(14.0, result);
    }

    [Fact]
    public void Dot_DifferentLengths_ThrowsArgumentException()
    {
        // Arrange
        var vector1 = new[] { 1.0, 2.0, 3.0 };
        var vector2 = new[] { 1.0, 2.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dot(vector1, vector2));
    }

    [Fact]
    public void Magnitude_ReturnsCorrectResult()
    {
        // Arrange
        var vector = new[] { 3.0, 4.0 };

        // Act
        var result = Eigenvalue.Magnitude(vector);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void ToColumnVector_ReturnsCorrectResult()
    {
        // Arrange
        var vector = new[] { 1.0, 2.0, 3.0 };

        // Act
        var result = Eigenvalue.ToColumnVector(vector);

        // Assert
        Assert.Equal(3, result.GetLength(0));
        Assert.Equal(1, result.GetLength(1));
        Assert.Equal(1.0, result[0, 0]);
        Assert.Equal(2.0, result[1, 0]);
        Assert.Equal(3.0, result[2, 0]);
    }

    [Fact]
    public void ToRowVector_ColumnVectorWithOneColumn_ReturnsCorrectResult()
    {
        // Arrange
        var columnVector = new[,] { { 1.0 }, { 2.0 }, { 3.0 } };

        // Act
        var result = Eigenvalue.ToRowVector(columnVector);

        // Assert
        Assert.Equal(new[] { 1.0, 2.0, 3.0 }, result);
    }

    [Fact]
    public void ToRowVector_ColumnVectorWithMultipleColumns_ThrowsInvalidOperationException()
    {
        // Arrange
        var columnVector = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Eigenvalue.ToRowVector(columnVector));
    }

    [Fact]
    public void Multiply_CompatibleMatrices_ReturnsCorrectResult()
    {
        // Arrange
        var matrix1 = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        var matrix2 = new[,] { { 5.0, 6.0 }, { 7.0, 8.0 } };

        // Act
        var result = Eigenvalue.Multiply(matrix1, matrix2);

        // Assert
        Assert.Equal(new[,] { { 19.0, 22.0 }, { 43.0, 50.0 } }, result);
    }

    // [Fact]
    // public void Multiply_IncompatibleMatrices_ThrowsInvalidOperationException()
    // {
    //     // Arrange
    //     var matrix1 = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
    //     var matrix2 = new[,] { { 5.0, 6.0, 7.0 }, { 8.0, 9.0, 10.0 } };
    //
    //     // Act & Assert
    //     Assert.Throws<InvalidOperationException>(() => Eigenvalue.Multiply(matrix1, matrix2));
    // }

    // [Fact]
    // public void Dominant_SquareMatrix_ReturnsCorrectResult()
    // {
    //     // Arrange
    //     var matrix = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
    //     var startVector = new[] { 1.0, 1.0 };
    //
    //     // Act
    //     var (eigenvalue, eigenvector) = Eigenvalue.Dominant(matrix, startVector);
    //
    //     // Assert
    //     Assert.Equal(5.0, eigenvalue, 6);
    //     // Assert.Equal(new[] { 0.4472136, 0.8944272 }, eigenvector, 6);
    // }

    [Fact]
    public void Dominant_NonSquareMatrix_ThrowsArgumentException()
    {
        // Arrange
        var matrix = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 }, { 5.0, 6.0 } };
        var startVector = new[] { 1.0, 1.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(matrix, startVector));
    }

    [Fact]
    public void Dominant_StartVectorLengthMismatch_ThrowsArgumentException()
    {
        // Arrange
        var matrix = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        var startVector = new[] { 1.0, 1.0, 1.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(matrix, startVector));
    }

    [Fact]
    public void Dominant_WithoutStartVector_ReturnsCorrectResult()
    {
        // Arrange
        var matrix = new[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };

        // Act
        var (eigenvalue, eigenvector) = Eigenvalue.Dominant(matrix);

        // Assert
        Assert.Equal(5.0, eigenvalue, 6);
        // Assert.Equal(new[] { 0.4472136, 0.8944272 }, eigenvector, 6);
    }

    [Fact]
    public void NextVector_ReturnsNormalizedVector()
    {
        // Arrange
        var rand = new Random(123456); // Fixed seed for reproducibility

        // Act
        var vector = Eigenvalue.NextVector(rand, 3);

        // Assert
        Assert.Equal(3, vector.Length);
        Assert.Equal(1.0, vector.Magnitude(), 6);
    }
}