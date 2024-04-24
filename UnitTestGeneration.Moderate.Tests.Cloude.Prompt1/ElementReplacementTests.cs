using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_SingleElement_ReturnsMinusOne()
    {
        // Arrange
        int[] arr = { 17 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { -1 }, result);
    }

    [Fact]
    public void ReplaceElements_TwoElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { 17, 18 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 18, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_MultipleElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { 17, 18, 5, 4, 6, 1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 18, 6, 6, 6, 1, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = Array.Empty<int>();

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Empty(result);
    }
}