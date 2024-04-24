using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class GeometricShapesTests
{
[Fact]
    public void RectangleArea_DefaultValues_ReturnsCorrectArea()
    {
        // Arrange
        var expected = new Tuple<double, double>(264, 68);

        // Act
        var result = GeometricShapes.RectangleShape.Area();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RectangleArea_CustomValues_ReturnsCorrectArea()
    {
        // Arrange
        float length = 5;
        float breadth = 10;
        var expected = new Tuple<double, double>(50, 30);

        // Act
        var result = GeometricShapes.RectangleShape.Area(length, breadth);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TriangleArea_DefaultValues_ReturnsCorrectArea()
    {
        // Arrange
        var expected = new Tuple<double, double>(32.5, 27);

        // Act
        var result = GeometricShapes.TriangleShape.Area();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TriangleArea_CustomValues_ReturnsCorrectArea()
    {
        // Arrange
        float _base = 10;
        float height = 20;
        float side1 = 15;
        float side2 = 25;
        var expected = new Tuple<double, double>(100, 50);

        // Act
        var result = GeometricShapes.TriangleShape.Area(_base, height, side1, side2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SquareArea_DefaultValue_ReturnsCorrectArea()
    {
        // Arrange
        var expected = new Tuple<double, double>(144, 48);

        // Act
        var result = GeometricShapes.SquareShape.Area();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SquareArea_CustomValue_ReturnsCorrectArea()
    {
        // Arrange
        float side = 5;
        var expected = new Tuple<double, double>(25, 20);

        // Act
        var result = GeometricShapes.SquareShape.Area(side);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CircleArea_DefaultValue_ReturnsCorrectArea()
    {
        // Arrange
        var expected = new Tuple<double, double>(1256, 251.2);

        // Act
        var result = GeometricShapes.CircleShape.Area();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CircleArea_CustomValue_ReturnsCorrectArea()
    {
        // Arrange
        float radius = 10;
        var expected = new Tuple<double, double>(314, 125.6);

        // Act
        var result = GeometricShapes.CircleShape.Area(radius);

        // Assert
        Assert.Equal(expected, result);
    }
}