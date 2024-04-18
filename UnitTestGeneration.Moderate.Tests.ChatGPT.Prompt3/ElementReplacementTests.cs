using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_SingleElementArray_ReturnsMinusOne()
    {
        // Arrange
        int[] arr = new int[] { 5 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Single(result);
        Assert.Equal(-1, result[0]);
    }

    [Fact]
    public void ReplaceElements_MultipleElementArray_ReturnsReplacedArray()
    {
        // Arrange
        int[] arr = new int[] { 17, 18, 5, 4, 6, 1 };
        int[] expected = new int[] { 18, 6, 6, 6, 1, -1 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = new int[0];

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Empty(result);
    }
}