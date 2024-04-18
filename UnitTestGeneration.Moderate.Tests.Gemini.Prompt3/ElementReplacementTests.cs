using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class ElementReplacementTests
{
    [Fact]
    public void ReplaceElements_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { }, result); // Ensure an empty output array
    }

    [Fact]
    public void ReplaceElements_SingleElementArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] arr = new int[] { 42 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { -1 }, result);
    }

    [Fact]
    public void ReplaceElements_TypicalArray_ReturnsCorrectlyReplacedArray()
    {
        // Arrange
        int[] arr = new int[] { 17, 18, 5, 4, 6, 1 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { 18, 6, 6, 6, 1, -1 }, result);
    }

    [Fact]
    public void ReplaceElements_ArrayWithAllEqualElements_ReturnsAllNegativeOnes()
    {
        // Arrange
        int[] arr = new int[] { 10, 10, 10, 10 };

        // Act
        int[] result = ElementReplacement.ReplaceElements(arr);

        // Assert
        Assert.Equal(new int[] { -1, -1, -1, -1 }, result);
    }
}