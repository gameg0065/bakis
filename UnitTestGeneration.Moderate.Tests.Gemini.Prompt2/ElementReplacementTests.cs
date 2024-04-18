using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_EmptyArray_ReturnsEmptyArray() // Or other desired behavior
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { }, result); // Or other expected result
    }
    
    [Fact]
    public void ReplaceElements_SingleElementArray_ReturnsMinusOne() 
    {
        // Arrange
        int[] arr = new int[] { 12 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { -1 }, result); 
    }
    [Fact]
    public void ReplaceElements_TypicalArray_ReturnsCorrectReplacedArray()
    {
        // Arrange
        int[] arr = new int[] { 17, 18, 5, 4, 6, 1 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { 18, 6, 6, 6, 1, -1 }, result);
    }
}