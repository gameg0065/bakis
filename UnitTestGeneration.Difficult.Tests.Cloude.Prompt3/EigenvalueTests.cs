using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class EigenvalueTests
{
[Fact]
    public void Dot_ThrowsException_WhenArraysHaveDifferentLengths()
    {
        // Arrange
        double[] lhs = { 1.0, 2.0, 3.0 };
        double[] rhs = { 4.0, 5.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => lhs.Dot(rhs));
    }

    [Theory]
    [InlineData(new double[] { 1.0, 2.0 }, new double[] { 3.0, 4.0 }, 11.0)]
    [InlineData(new double[] { 0.0, 0.0 }, new double[] { 0.0, 0.0 }, 0.0)]
    [InlineData(new double[] { -1.0, 2.0 }, new double[] { 3.0, -4.0 }, -7.0)]
    public void Dot_CalculatesCorrectResult(double[] lhs, double[] rhs, double expected)
    {
        // Act
        double result = lhs.Dot(rhs);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new double[] { 3.0, 4.0 }, 5.0)]
    [InlineData(new double[] { 0.0, 0.0 }, 0.0)]
    [InlineData(new double[] { -2.0, -3.0 }, 3.605551275463989)]
    public void Magnitude_CalculatesCorrectResult(double[] vector, double expected)
    {
        // Act
        double result = vector.Magnitude();

        // Assert
        Assert.Equal(expected, result, 6);
    }

    [Fact]
    public void ToColumnVector_CreatesCorrectColumnVector()
    {
        // Arrange
        double[] source = { 1.0, 2.0, 3.0 };
        double[,] expected = new double[,] { { 1.0 }, { 2.0 }, { 3.0 } };

        // Act
        double[,] result = source.ToColumnVector();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToRowVector_ThrowsException_WhenColumnVectorHasMultipleColumns()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => source.ToRowVector());
    }

    [Fact]
    public void ToRowVector_CreatesCorrectRowVector()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0 }, { 2.0 }, { 3.0 } };
        double[] expected = { 1.0, 2.0, 3.0 };

        // Act
        double[] result = source.ToRowVector();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_ThrowsException_WhenDimensionsMismatch()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[,] operand = new double[,] { { 5.0 }, { 6.0 }, { 7.0 } };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => source.Multiply(operand));
    }

    [Fact]
    public void Multiply_CalculatesCorrectResult()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[,] operand = new double[,] { { 5.0, 6.0 }, { 7.0, 8.0 } };
        double[,] expected = new double[,] { { 19.0, 22.0 }, { 43.0, 50.0 } };

        // Act
        double[,] result = source.Multiply(operand);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Dominant_ThrowsException_WhenMatrixIsNotSquare()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 }, { 5.0, 6.0 } };
        double[] startVector = { 1.0, 2.0, 3.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(source, startVector));
    }

    [Fact]
    public void Dominant_ThrowsException_WhenStartVectorLengthDoesNotMatchMatrixSize()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[] startVector = { 1.0, 2.0, 3.0 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Eigenvalue.Dominant(source, startVector));
    }

    [Fact]
    public void Dominant_CalculatesCorrectEigenvalueAndEigenvector()
    {
        // Arrange
        double[,] source = new double[,] { { 1.0, 2.0 }, { 3.0, 4.0 } };
        double[] startVector = { 1.0, 1.0 };
        double expectedEigenvalue = 5.37228132;
        double[] expectedEigenvector = { 0.57735027, 0.81679115 };
        double error = 0.00001;

        // Act
        (double eigenvalue, double[] eigenvector) = Eigenvalue.Dominant(source, startVector, error);

        // Assert
        Assert.Equal(expectedEigenvalue, eigenvalue, 5);
        Assert.Equal(expectedEigenvector, eigenvector, new EigenvalueEqualityComparer(error));
    }

    [Fact]
    public void NextVector_GeneratesNormalizedRandomVector()
    {
        // Arrange
        int size = 3;
        var rand = new Random(123); // Fixed seed for deterministic testing

        // Act
        double[] vector = rand.NextVector(size);

        // Assert
        Assert.Equal(3, vector.Length);
        Assert.Equal(1.0, vector.Magnitude(), 6);
    }

    private class EigenvalueEqualityComparer : IEqualityComparer<double[]>
    {
        private readonly double _error;

        public EigenvalueEqualityComparer(double error)
        {
            _error = error;
        }

        public bool Equals(double[] x, double[] y)
        {
            if (x.Length != y.Length)
                return false;

            for (int i = 0; i < x.Length; i++)
            {
                if (Math.Abs(x[i] - y[i]) > _error)
                    return false;
            }

            return true;
        }

        public int GetHashCode(double[] obj)
        {
            return obj.GetHashCode();
        }
    }
}