using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class GeometricShapesTests
{
    public class RectangleTests
    {
        [Fact]
        public void DefaultArea_CalculatesCorrectly() 
        {
            var result = GeometricShapes.RectangleShape.Area();
            Assert.Equal(264, result.Item1);  // Area: 12 * 22
            Assert.Equal(68, result.Item2);   // Perimeter: 2 * (12 + 22)
        }

        [Fact]
        public void CustomArea_CalculatesCorrectly() 
        {
            var result = GeometricShapes.RectangleShape.Area(5, 8);
            Assert.Equal(40, result.Item1);     // Area: 5 * 8
            Assert.Equal(26, result.Item2);     // Perimeter: 2 * (5 + 8)
        }
    }
}