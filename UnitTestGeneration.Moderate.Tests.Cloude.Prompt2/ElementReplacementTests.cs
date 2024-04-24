using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = { };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void ReplaceElements_SingleElementArray_ReturnsArrayWithMinusOne()
    {
        // Arrange
        int[] arr = { 5 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Single(result, -1);
    }

    [Fact]
    public void ReplaceElements_ArrayWithTwoElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { 5, 10 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 10, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_ArrayWithMultipleElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { 17, 18, 5, 4, 6, 1 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 18, 6, 6, 6, 1, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_ArrayWithDuplicateElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { 5, 5, 5, 5, 5 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 5, 5, 5, 5, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_ArrayWithNegativeElements_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr = { -5, -10, -15, 20, 25 };

        // Act
        var result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new[] { 25, 25, 20, 25, -1 }, result);
    }
}