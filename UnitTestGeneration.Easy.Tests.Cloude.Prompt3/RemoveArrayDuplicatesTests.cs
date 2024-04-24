using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class RemoveArrayDuplicatesTests
{
    [Theory]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1 }, 1)]
    [InlineData(new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 1, 1, 2, 2 }, 2)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, 3)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicates_ReturnsCorrectLength(int[] nums, int expected)
    {
        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
    public void RemoveDuplicates_ModifiesOriginalArray(int[] nums, int[] expected)
    {
        // Act
        int length = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected.Length, length);
        Assert.Equal(expected, nums.Take(length));
    }

    [Fact]
    public void RemoveDuplicates_WithNullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] nums = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => RemoveArrayDuplicates.RemoveDuplicates(nums));
    }
}