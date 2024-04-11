using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class GeometricShapesTests
{
    [Fact]
    public void TestDefaultValues()
    {
        var expectedArea = 264.0;
        var expectedPerimeter = 68.0;

        var result = GeometricShapes.RectangleShape.Area();
        Assert.Equal(expectedArea, result.Item1);
        Assert.Equal(expectedPerimeter, result.Item2);
    }

    [Fact]
    public void TestCustomValues()
    {
        float length = 5.5f;
        float breadth = 8f;
        var expectedArea = 44.0;
        var expectedPerimeter = 27.0;

        var result = GeometricShapes.RectangleShape.Area(length, breadth);
        Assert.Equal(expectedArea, result.Item1);
        Assert.Equal(expectedPerimeter, result.Item2);
    }

    [Fact]
    public void TestZeroValues()
    {
        // Should likely throw an ArgumentException, 
        // but you'll need to adjust code if that's desired behavior
        Assert.Throws<ArgumentException>(() => GeometricShapes.RectangleShape.Area(0, 0)); 
    }

    [Fact]
    public void TestNegativeValues()
    {
        // Consider how to handle negative values 
        Assert.Throws<ArgumentException>(() => GeometricShapes.RectangleShape.Area(-1, 5)); 
    }
}