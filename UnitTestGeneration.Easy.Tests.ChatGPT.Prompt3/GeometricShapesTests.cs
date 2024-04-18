using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class GeometricShapesTests
{
[Fact]
    public void RectangleShape_Area_ShouldReturnCorrectResult_WithDefaultValues()
    {
        // Act
        var result = GeometricShapes.RectangleShape.Area();

        // Assert
        Assert.Equal(12 * 22, result.Item1); // Area = length * breadth
        Assert.Equal(2 * (12 + 22), result.Item2); // Perimeter = 2 * (length + breadth)
    }

    [Fact]
    public void RectangleShape_Area_ShouldReturnCorrectResult_WithCustomValues()
    {
        // Arrange
        float length = 5;
        float breadth = 10;

        // Act
        var result = GeometricShapes.RectangleShape.Area(length, breadth);

        // Assert
        Assert.Equal(length * breadth, result.Item1); // Area = length * breadth
        Assert.Equal(2 * (length + breadth), result.Item2); // Perimeter = 2 * (length + breadth)
    }

    [Fact]
    public void TriangleShape_Area_ShouldReturnCorrectResult_WithDefaultValues()
    {
        // Act
        var result = GeometricShapes.TriangleShape.Area();

        // Assert
        Assert.Equal((5 * 13) / 2, result.Item1); // Area = (base * height) / 2
        Assert.Equal(5 + 12 + 10, result.Item2); // Perimeter = base + side1 + side2
    }

    [Fact]
    public void TriangleShape_Area_ShouldReturnCorrectResult_WithCustomValues()
    {
        // Arrange
        float _base = 6;
        float height = 12;
        float side1 = 8;
        float side2 = 10;

        // Act
        var result = GeometricShapes.TriangleShape.Area(_base, height, side1, side2);

        // Assert
        Assert.Equal((_base * height) / 2, result.Item1); // Area = (base * height) / 2
        Assert.Equal(_base + side1 + side2, result.Item2); // Perimeter = base + side1 + side2
    }

    [Fact]
    public void SquareShape_Area_ShouldReturnCorrectResult_WithDefaultValues()
    {
        // Act
        var result = GeometricShapes.SquareShape.Area();

        // Assert
        Assert.Equal(12 * 12, result.Item1); // Area = side * side
        Assert.Equal(4 * 12, result.Item2); // Perimeter = 4 * side
    }

    [Fact]
    public void SquareShape_Area_ShouldReturnCorrectResult_WithCustomValues()
    {
        // Arrange
        float side = 8;

        // Act
        var result = GeometricShapes.SquareShape.Area(side);

        // Assert
        Assert.Equal(side * side, result.Item1); // Area = side * side
        Assert.Equal(4 * side, result.Item2); // Perimeter = 4 * side
    }

    [Fact]
    public void CircleShape_Area_ShouldReturnCorrectResult_WithDefaultValues()
    {
        // Act
        var result = GeometricShapes.CircleShape.Area();

        // Assert
        Assert.Equal(3.14 * 20 * 20, result.Item1); // Area = π * radius * radius
        Assert.Equal(4 * 3.14 * 20, result.Item2); // Circumference = 2 * π * radius
    }

    [Fact]
    public void CircleShape_Area_ShouldReturnCorrectResult_WithCustomValues()
    {
        // Arrange
        float radius = 15;

        // Act
        var result = GeometricShapes.CircleShape.Area(radius);

        // Assert
        Assert.Equal(3.14 * radius * radius, result.Item1); // Area = π * radius * radius
        Assert.Equal(4 * 3.14 * radius, result.Item2); // Circumference = 2 * π * radius
    }
}