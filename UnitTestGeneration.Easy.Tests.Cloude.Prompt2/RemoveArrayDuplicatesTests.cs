using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithoutDuplicates_ReturnsOriginalLength()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(nums.Length, result);
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithDuplicates_RemovesDuplicatesAndReturnsCorrectLength()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] expected = { 0, 1, 2, 3, 4 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected.Length, result);
        for (int i = 0; i < result; i++)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithAllSameElements_ReturnsOne()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1, 1 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(1, result);
        Assert.Equal(1, nums[0]);
    }

    [Fact]
    public void RemoveDuplicates_ArrayWithNegativeValues_RemovesDuplicatesAndReturnsCorrectLength()
    {
        // Arrange
        int[] nums = { -1, 0, 0, 0, 0, 3, 3, 3, 9, 9, 9, 9 };
        int[] expected = { -1, 0, 3, 9 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected.Length, result);
        for (int i = 0; i < result; i++)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }
}