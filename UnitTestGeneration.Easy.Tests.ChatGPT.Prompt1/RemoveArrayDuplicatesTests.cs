using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

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
    public void RemoveDuplicates_ShouldReturnLengthOfUniqueElements_WhenArrayHasDuplicates()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result); // Unique elements: 0, 1, 2, 3, 4
    }

    [Fact]
    public void RemoveDuplicates_ShouldReturnLengthOfArray_WhenArrayHasNoDuplicates()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result); // All elements are unique
    }
}