using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class GeometricShapesTests
{
    [Fact]
    public void RectangleArea_ShouldCalculateCorrectly()
    {
        // Arrange
        float length = 12;
        float breadth = 22;

        // Act
        var result = GeometricShapes.RectangleShape.Area(length, breadth);

        // Assert
        Assert.Equal(length * breadth, result.Item1);
        Assert.Equal(2 * (length + breadth), result.Item2);
    }

    [Fact]
    public void TriangleArea_ShouldCalculateCorrectly()
    {
        // Arrange
        float _base = 5;
        float height = 13;
        float side1 = 12;
        float side2 = 10;

        // Act
        var result = GeometricShapes.TriangleShape.Area(_base, height, side1, side2);

        // Assert
        Assert.Equal(_base * height / 2, result.Item1);
        Assert.Equal(_base + side1 + side2, result.Item2);
    }

    [Fact]
    public void SquareArea_ShouldCalculateCorrectly()
    {
        // Arrange
        float side = 12;

        // Act
        var result = GeometricShapes.SquareShape.Area(side);

        // Assert
        Assert.Equal(side * side, result.Item1);
        Assert.Equal(4 * side, result.Item2);
    }

    [Fact]
    public void CircleArea_ShouldCalculateCorrectly()
    {
        // Arrange
        float radius = 20;

        // Act
        var result = GeometricShapes.CircleShape.Area(radius);

        // Assert
        Assert.Equal(3.14 * radius * radius, result.Item1, precision: 5); // using precision 5 for floating point comparison
        Assert.Equal(4 * 3.14 * radius, result.Item2, precision: 5);
    }
}