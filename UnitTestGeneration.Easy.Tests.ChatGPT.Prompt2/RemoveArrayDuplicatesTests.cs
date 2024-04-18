using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_ShouldReturnZero_WhenArrayIsEmpty()
    {
        // Arrange
        int[] nums = { };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldReturnLengthOfOne_WhenArrayHasNoDuplicates()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldReturnCorrectLength_WhenArrayHasDuplicates()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldModifyArray_WhenArrayHasDuplicates()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(0, nums[0]);
        Assert.Equal(1, nums[1]);
        Assert.Equal(2, nums[2]);
        Assert.Equal(3, nums[3]);
        Assert.Equal(4, nums[4]);
    }   
}