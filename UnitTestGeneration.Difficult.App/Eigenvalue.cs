using System.Collections;

namespace UnitTestGeneration.Difficult.App;


//https://github.com/TheAlgorithms/C-Sharp/blob/master/Algorithms/LinearAlgebra/Eigenvalue/PowerIteration.cs
// cy = 20, co = 15

public static class Eigenvalue
{
    public static double Dot(this double[] lhs, double[] rhs)
    {
        if (lhs.Length != rhs.Length)
        {
            throw new ArgumentException("Dot product arguments must have same dimension");
        }

        double result = 0;
        for (var i = 0; i < lhs.Length; i++)
        {
            result += lhs[i] * rhs[i];
        }

        return result;
    }

 
    public static double Magnitude(this double[] vector)
    {
        var magnitude = Dot(vector, vector);
        magnitude = Math.Sqrt(magnitude);
        return magnitude;
    }
    
    public static double[,] ToColumnVector(this double[] source)
    {
        var columnVector = new double[source.Length, 1];

        for (var i = 0; i < source.Length; i++)
        {
            columnVector[i, 0] = source[i];
        }

        return columnVector;
    }
    
    public static double[] ToRowVector(this double[,] source)
    {
        if (source.GetLength(1) != 1)
        {
            throw new InvalidOperationException("The column vector should have only 1 element in width.");
        }

        var rowVector = new double[source.Length];

        for (var i = 0; i < rowVector.Length; i++)
        {
            rowVector[i] = source[i, 0];
        }

        return rowVector;
    }
    
    
    public static double[,] Multiply(this double[,] source, double[,] operand)
    {
        if (source.GetLength(1) != operand.GetLength(0))
        {
            throw new InvalidOperationException(
                "The width of a first operand should match the height of a second.");
        }

        var result = new double[source.GetLength(0), operand.GetLength(1)];

        for (var i = 0; i < result.GetLength(0); i++)
        {
            for (var j = 0; j < result.GetLength(1); j++)
            {
                double elementProduct = 0;

                for (var k = 0; k < source.GetLength(1); k++)
                {
                    elementProduct += source[i, k] * operand[k, j];
                }

                result[i, j] = elementProduct;
            }
        }

        return result;
    }
    
        public static (double eigenvalue, double[] eigenvector) Dominant(
        double[,] source,
        double[] startVector,
        double error = 0.00001)
    {
        if (source.GetLength(0) != source.GetLength(1))
        {
            throw new ArgumentException("The source matrix is not square-shaped.");
        }

        if (source.GetLength(0) != startVector.Length)
        {
            throw new ArgumentException(
                "The length of the start vector doesn't equal the size of the source matrix.");
        }

        double eigenNorm;
        double[] previousEigenVector;
        double[] currentEigenVector = startVector;

        do
        {
            previousEigenVector = currentEigenVector;
            currentEigenVector = source.Multiply(
                    previousEigenVector.ToColumnVector())
                .ToRowVector();

            eigenNorm = currentEigenVector.Magnitude();
            currentEigenVector = currentEigenVector.Select(x => x / eigenNorm).ToArray();
        }
        while (Math.Abs(currentEigenVector.Dot(previousEigenVector)) < 1.0 - error);

        var eigenvalue = source.Multiply(currentEigenVector.ToColumnVector()).ToRowVector().Magnitude();

        return (eigenvalue, eigenvector: currentEigenVector);
    }

   
    public static (double eigenvalue, double[] eigenvector) Dominant(double[,] source, double error = 0.00001) =>
        Dominant(source, new Random().NextVector(source.GetLength(1)), error);
    
    public static double[] NextVector(this Random rand, int size)
    {
        var vector = Enumerable.Range(0, size)
            .Select(_ => rand.NextDouble()).ToArray();
        var norm = vector.Magnitude();
        return vector.Select(x => x / norm).ToArray();
    }
}