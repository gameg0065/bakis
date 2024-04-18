using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

public class ValidateArrayTests
{
    [Theory]
    [InlineData(new int[] { 0, 2, 3, 2, 1 }, true)] // Valid mountain array
    [InlineData(new int[] { 0, 2, 3, 2, 2, 1 }, false)] // Not strictly decreasing after the peak
    [InlineData(new int[] { 0, 2, 2, 3, 1 }, false)] // Not strictly increasing before the peak
    [InlineData(new int[] { 0, 2, 3, 4, 5 }, false)] // No peak
    [InlineData(new int[] { }, false)] // Empty array
    [InlineData(new int[] { 1 }, false)] // Array with one element
    [InlineData(new int[] { 1, 2 }, false)] // Array with two elements
    public void ValidMountainArray_ValidCases_ReturnsExpected(int[] arr, bool expected)
    {
        // Arrange
        var validator = new ValidateArray();

        // Act
        bool result = validator.ValidMountainArray(arr);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ValidMountainArray_SameConsecutiveElements_ReturnsFalse()
    {
        // Arrange
        var validator = new ValidateArray();
        int[] arr = { 1, 1, 1, 1 };

        // Act
        bool result = validator.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }
}