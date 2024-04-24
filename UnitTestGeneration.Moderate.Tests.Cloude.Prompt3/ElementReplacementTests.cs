using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class ElementReplacementTests
{
[Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 17 }, new int[] { -1 })]
    [InlineData(new int[] { 17, 18 }, new int[] { 18, -1 })]
    [InlineData(new int[] { 17, 18, 5 }, new int[] { 18, 5, -1 })]
    [InlineData(new int[] { 17, 18, 5, 4, 6, 1 }, new int[] { 18, 6, 6, 6, 1, -1 })]
    public void ReplaceElements_ShouldReplaceElementsWithGreatestElementOnRightSide(int[] input, int[] expected)
    {
        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };

        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ShouldHandleSingleElementArray()
    {
        // Arrange
        int[] input = { 17 };
        int[] expected = { -1 };

        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ShouldHandleArrayWithAllElementsSame()
    {
        // Arrange
        int[] input = { 5, 5, 5, 5 };
        int[] expected = { 5, 5, 5, -1 };

        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ShouldHandleArrayWithDescendingOrder()
    {
        // Arrange
        int[] input = { 10, 9, 8, 7, 6, 5 };
        int[] expected = { 9, 8, 7, 6, 5, -1 };

        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReplaceElements_ShouldHandleArrayWithAscendingOrder()
    {
        // Arrange
        int[] input = { 5, 6, 7, 8, 9, 10 };
        int[] expected = { 10, 10, 10, 10, 10, -1 };

        // Act
        var result = ElementReplacement.ReplaceElements(input);

        // Assert
        Assert.Equal(expected, result);
    }
}