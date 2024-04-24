using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class GeometricShapesTests
{
[Theory]
    [InlineData(12, 22, 264, 68)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(-5, 10, -50, 10)]
    [InlineData(float.MaxValue, float.MaxValue, double.PositiveInfinity, double.PositiveInfinity)]
    public void RectangleArea_ShouldReturnCorrectArea(float length, float breadth, double expectedArea, double expectedPerimeter)
    {
        var result = GeometricShapes.RectangleShape.Area(length, breadth);
        Assert.Equal(expectedArea, result.Item1);
        Assert.Equal(expectedPerimeter, result.Item2);
    }

    [Theory]
    [InlineData(5, 13, 12, 10, 32.5, 27)]
    [InlineData(0, 0, 0, 0, 0, 0)]
    [InlineData(-5, 10, 12, -10, -25, 17)]
    [InlineData(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, double.PositiveInfinity, double.PositiveInfinity)]
    public void TriangleArea_ShouldReturnCorrectArea(float _base, float height, float side1, float side2, double expectedArea, double expectedPerimeter)
    {
        var result = GeometricShapes.TriangleShape.Area(_base, height, side1, side2);
        Assert.Equal(expectedArea, result.Item1);
        Assert.Equal(expectedPerimeter, result.Item2);
    }

    [Theory]
    [InlineData(12, 144, 48)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 25, -20)]
    [InlineData(float.MaxValue, double.PositiveInfinity, double.PositiveInfinity)]
    public void SquareArea_ShouldReturnCorrectArea(float side, double expectedArea, double expectedPerimeter)
    {
        var result = GeometricShapes.SquareShape.Area(side);
        Assert.Equal(expectedArea, result.Item1);
        Assert.Equal(expectedPerimeter, result.Item2);
    }

    [Theory]
    [InlineData(20, 1256.64, 251.33)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -78.54, -62.83)]
    [InlineData(float.MaxValue, double.PositiveInfinity, double.PositiveInfinity)]
    public void CircleArea_ShouldReturnCorrectArea(float radius, double expectedArea, double expectedPerimeter)
    {
        var result = GeometricShapes.CircleShape.Area(radius);
        Assert.Equal(expectedArea, result.Item1, 2); // Allow delta of 2 for floating-point precision
        Assert.Equal(expectedPerimeter, result.Item2, 2);
    }
}