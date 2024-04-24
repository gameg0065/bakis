using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_ArrayWithDuplicates_ReturnsCorrectLength()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int expected = 5;

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
        Assert.Equal(new[] { 0, 1, 2, 3, 4 }, nums.Take(result));
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithoutDuplicates_ReturnsOriginalLength()
    {
        // Arrange
        int[] nums = { 0, 1, 2, 3, 4 };
        int expected = 5;

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
        Assert.Equal(new[] { 0, 1, 2, 3, 4 }, nums.Take(result));
    }

    [Fact]
    public void RemoveDuplicates_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithAllDuplicates_ReturnsOne()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1, 1 };
        int expected = 1;

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
        Assert.Equal(new[] { 1 }, nums.Take(result));
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithSingleElement_ReturnsOne()
    {
        // Arrange
        int[] nums = { 1 };
        int expected = 1;

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected, result);
        Assert.Equal(new[] { 1 }, nums.Take(result));
    }
}