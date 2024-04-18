using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class ValidateArrayTests
{
    private readonly ValidateArray validator = new ValidateArray();

    [Theory]
    [InlineData(new int[] { }, false)] // Empty array
    [InlineData(new int[] { 1 }, false)] // Array with one element
    [InlineData(new int[] { 1, 2 }, false)] // Array with two elements
    public void ValidMountainArray_ArrayLessThan3Elements_ReturnsFalse(int[] arr, bool expected)
    {
        // Act
        bool result = validator.ValidMountainArray(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, true)] // Mountain pattern
    [InlineData(new int[] { 0, 2, 3, 4, 5, 2, 1, 0 }, true)] // Mountain pattern
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, false)] // Not a mountain pattern
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, false)] // Not a mountain pattern
    [InlineData(new int[] { 1, 2, 2, 3, 1 }, false)] // Array with duplicate elements
    public void ValidMountainArray_ReturnsExpectedResult(int[] arr, bool expected)
    {
        // Act
        bool result = validator.ValidMountainArray(arr);

        // Assert
        Assert.Equal(expected, result);
    }
}