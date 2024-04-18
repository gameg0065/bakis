using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class GeometricShapesTests
{
    [Fact]
    public void Area_ZeroLength_ReturnsZero()
    {
        var result = GeometricShapes.RectangleShape.Area(length: 0);
        Assert.Equal(0, result.Item1); 
        Assert.Equal(0, result.Item2); 
    }

    [Fact]
    public void Area_NegativeValues_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => GeometricShapes.RectangleShape.Area(length: -10));
        Assert.Throws<ArgumentException>(() => GeometricShapes.RectangleShape.Area(breadth: -5));
    }

    [Fact]
    public void Area_CustomValues_CalculatesCorrectly()
    {
        var result = GeometricShapes.RectangleShape.Area(length: 5, breadth: 8);
        Assert.Equal(40, result.Item1);
        Assert.Equal(26, result.Item2);
    }
}