using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class SqrtFunctionTests
{
    [Fact]
    public void TestPositiveNumber()
    {
        decimal x = 25;
        decimal expectedResult = 5; 

        decimal result = SqrtFunction.Sqrt(x);
        Assert.Equal(expectedResult, result); 
    }

    [Fact]
    public void TestZero()
    {
        decimal x = 0;
        decimal expectedResult = 0;

        decimal result = SqrtFunction.Sqrt(x);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestNegativeNumber()
    {
        decimal x = -10;
        Assert.Throws<OverflowException>(() => SqrtFunction.Sqrt(x));
    }

    [Fact]
    public void TestDecimalPrecision()
    {
        decimal x = 2; 
        decimal epsilon = 0.0001M; // Tolerance for precision
        decimal expectedResult = 1.4142M; // Approximate 

        decimal result = SqrtFunction.Sqrt(x, epsilon);

        // Check if the result is within the specified tolerance
        Assert.InRange(result, expectedResult - epsilon, expectedResult + epsilon); 
    }
}