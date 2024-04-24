using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class EigenvalueTests
{
[Fact]
    public void Dot_VectorsWithSameLength_ReturnsCorrectResult()
    {
        // Arrange
        double[] lhs = { 1, 2, 3 };
        double[] rhs = { 4, 5, 6 };
        double expected = 32;

        // Act
        double result = Eigenvalue.Dot(lhs, rhs);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Dot_VectorsWithDifferentLengths_ThrowsArgumentException()
    {
        // Arrange
        double[] lhs = { 1, 2, 3 };
        double[] rhs = { 4, 5 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dot(lhs, rhs));
    }

    [Fact]
    public void Magnitude_ValidVector_ReturnsCorrectResult()
    {
        // Arrange
        double[] vector = { 3, 4 };
        double expected = 5;

        // Act
        double result = Eigenvalue.Magnitude(vector);

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void ToColumnVector_ValidVector_ReturnsCorrectResult()
    {
        // Arrange
        double[] source = { 1, 2, 3 };
        double[,] expected = { { 1 }, { 2 }, { 3 } };

        // Act
        double[,] result = Eigenvalue.ToColumnVector(source);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToRowVector_ValidColumnVector_ReturnsCorrectResult()
    {
        // Arrange
        double[,] source = { { 1 }, { 2 }, { 3 } };
        double[] expected = { 1, 2, 3 };

        // Act
        double[] result = Eigenvalue.ToRowVector(source);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToRowVector_InvalidColumnVector_ThrowsInvalidOperationException()
    {
        // Arrange
        double[,] source = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Eigenvalue.ToRowVector(source));
    }

    [Fact]
    public void Multiply_ValidMatrices_ReturnsCorrectResult()
    {
        // Arrange
        double[,] source = { { 1, 2 }, { 3, 4 } };
        double[,] operand = { { 5, 6 }, { 7, 8 } };
        double[,] expected = { { 19, 22 }, { 43, 50 } };

        // Act
        double[,] result = Eigenvalue.Multiply(source, operand);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_IncompatibleMatrices_ThrowsInvalidOperationException()
    {
        // Arrange
        double[,] source = { { 1, 2 }, { 3, 4 } };
        double[,] operand = { { 5, 6 }, { 7, 8 }, { 9, 10 } };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Eigenvalue.Multiply(source, operand));
    }

    [Fact]
    public void Dominant_SquareMatrix_ReturnsCorrectResult()
    {
        // Arrange
        double[,] source = { { 1, 2 }, { 3, 4 } };
        double[] startVector = { 1, 1 };
        double error = 0.00001;
        double expectedEigenvalue = 5.37228;
        double[] expectedEigenvector = { 0.913545, 0.406737 };

        // Act
        (double eigenvalue, double[] eigenvector) result = Eigenvalue.Dominant(source, startVector, error);

        // Assert
        Assert.Equal(expectedEigenvalue, result.eigenvalue, 5);
        Assert.Equal(expectedEigenvector, result.eigenvector, new DifferenceInArraysComparer<double>(error));
    }

    [Fact]
    public void Dominant_NonSquareMatrix_ThrowsArgumentException()
    {
        // Arrange
        double[,] source = { { 1, 2, 3 }, { 4, 5, 6 } };
        double[] startVector = { 1, 1, 1 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(source, startVector));
    }

    [Fact]
    public void Dominant_StartVectorWithWrongLength_ThrowsArgumentException()
    {
        // Arrange
        double[,] source = { { 1, 2 }, { 3, 4 } };
        double[] startVector = { 1, 1, 1 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(source, startVector));
    }

    [Fact]
    public void NextVector_ValidSize_ReturnsUnitVector()
    {
        // Arrange
        int size = 3;
        var rand = new Random(1234);

        // Act
        double[] result = Eigenvalue.NextVector(rand, size);

        // Assert
        Assert.Equal(3, result.Length);
        Assert.Equal(1, result.Magnitude(), 6);
    }
}

public class DifferenceInArraysComparer<T> : IEqualityComparer<T[]>
{
    private readonly double _error;

    public DifferenceInArraysComparer(double error)
    {
        _error = error;
    }

    public bool Equals(T[] x, T[] y)
    {
        if (x.Length != y.Length)
            return false;

        for (int i = 0; i < x.Length; i++)
        {
            if (!DoubleEquals(Convert.ToDouble(x[i]), Convert.ToDouble(y[i]), _error))
                return false;
        }

        return true;
    }

    public int GetHashCode(T[] obj)
    {
        return obj.GetHashCode();
    }

    private bool DoubleEquals(double a, double b, double error)
    {
        return Math.Abs(a - b) < error;
    }
}