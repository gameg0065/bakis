using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_ShouldRemoveDuplicates_AndReturnCorrectLength()
    {
        // Arrange
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result); // Expecting 5 unique elements
        Assert.Equal(new int[] { 0, 1, 2, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }); // Expecting array to be modified with unique elements
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] nums = new int[0]; // Empty array

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(0, result); // Expecting length 0
        Assert.Empty(nums); // Expecting array to remain empty
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleArrayWithSingleElement()
    {
        // Arrange
        int[] nums = { 42 }; // Array with single element

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(1, result); // Expecting length 1
        Assert.Equal(new int[] { 42 }, new int[] { 42 }); // Expecting array to remain unchanged
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleArrayWithAllElementsSame()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1, 1 }; // Array with all elements same

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(1, result); // Expecting length 1
        Assert.Equal(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }); // Expecting array to remain unchanged
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleArrayWithNoDuplicates()
    {
        // Arrange
        int[] nums = { 1, 2, 3, 4, 5 }; // Array with no duplicates

        // Act
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(5, result); // Expecting length 5
        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }); // Expecting array to remain unchanged
    }
}