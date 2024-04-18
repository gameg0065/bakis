using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_ReturnsExpectedArray_WhenInputArrayIsValid()
    {
        // Arrange
        int[] arr = { 17, 18, 5, 4, 6, 1 };
        int[] expected = { 18, 6, 6, 6, 1, -1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ReturnsNegativeOne_WhenInputArrayHasSingleElement()
    {
        // Arrange
        int[] arr = { 5 };
        int[] expected = { -1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ReturnsExpectedArray_WhenInputArrayIsEmpty()
    {
        // Arrange
        int[] arr = { };
        int[] expected = { };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ReturnsExpectedArray_WhenInputArrayHasAllSameElements()
    {
        // Arrange
        int[] arr = { 3, 3, 3, 3 };
        int[] expected = { 3, 3, 3, -1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ReturnsExpectedArray_WhenInputArrayHasDescendingOrderElements()
    {
        // Arrange
        int[] arr = { 5, 4, 3, 2, 1 };
        int[] expected = { 4, 3, 2, 1, -1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }
}