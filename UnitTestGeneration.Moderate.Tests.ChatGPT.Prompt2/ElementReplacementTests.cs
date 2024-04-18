using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_ReturnsEmptyArray_WhenInputIsEmpty()
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void ReplaceElements_ReturnsNegativeOne_WhenInputHasSingleElement()
    {
        // Arrange
        int[] arr = new int[] { 5 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { -1 }, result);
    }

    [Theory]
    [InlineData(new int[] { 17, 18, 5, 4, 6, 1 }, new int[] { 18, 6, 6, 6, 1, -1 })]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 4, 3, 2, 1, -1 })]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, new int[] { 3, 3, 2, 1, -1 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, -1 })]
    public void ReplaceElements_ReturnsExpectedResult_ForDifferentArrays(int[] arr, int[] expected)
    {
        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(expected, result);
    }
}