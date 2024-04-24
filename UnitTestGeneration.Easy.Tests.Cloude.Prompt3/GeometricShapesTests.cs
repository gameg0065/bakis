using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class GeometricShapesTests
{
[Theory]
    [InlineData(12, 22, 264, 68)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(-5, 10, -50, 10)]
    [InlineData(float.MaxValue, float.MaxValue, float.MaxValue * float.MaxValue, float.MaxValue * 2)]
    public void RectangleArea_ShouldCalculateCorrectly(float length, float breadth, double expectedArea, double expectedPerimeter)
    {
        // Arrange

        // Act
        var result = GeometricShapes.RectangleShape.Area(length, breadth);

        // Assert
        Assert.Equal(expectedArea, result.Item1, 6);
        Assert.Equal(expectedPerimeter, result.Item2, 6);
    }

    [Theory]
    [InlineData(5, 13, 12, 10, 32.5, 27)]
    [InlineData(0, 0, 0, 0, 0, 0)]
    [InlineData(-5, 10, 12, -10, -25, 17)]
    [InlineData(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue * float.MaxValue / 2, float.MaxValue * 3)]
    public void TriangleArea_ShouldCalculateCorrectly(float _base, float height, float side1, float side2, double expectedArea, double expectedPerimeter)
    {
        // Arrange

        // Act
        var result = GeometricShapes.TriangleShape.Area(_base, height, side1, side2);

        // Assert
        Assert.Equal(expectedArea, result.Item1, 6);
        Assert.Equal(expectedPerimeter, result.Item2, 6);
    }

    [Theory]
    [InlineData(12, 144, 48)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 25, -20)]
    [InlineData(float.MaxValue, float.MaxValue * float.MaxValue, float.MaxValue * 4)]
    public void SquareArea_ShouldCalculateCorrectly(float side, double expectedArea, double expectedPerimeter)
    {
        // Arrange

        // Act
        var result = GeometricShapes.SquareShape.Area(side);

        // Assert
        Assert.Equal(expectedArea, result.Item1, 6);
        Assert.Equal(expectedPerimeter, result.Item2, 6);
    }

    [Theory]
    [InlineData(20, 1256.64, 251.33)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 78.54, -62.83)]
    [InlineData(float.MaxValue, 3.14f * float.MaxValue * float.MaxValue, 4f * 3.14f * float.MaxValue)]
    public void CircleArea_ShouldCalculateCorrectly(float radius, double expectedArea, double expectedPerimeter)
    {
        // Arrange

        // Act
        var result = GeometricShapes.CircleShape.Area(radius);

        // Assert
        Assert.Equal(expectedArea, result.Item1, 2);
        Assert.Equal(expectedPerimeter, result.Item2, 2);
    }
}