using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void RemoveDuplicates_EmptyArray_ReturnsZero()
    {
        int[] nums = new int[0];
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(0, result); 
    }

    [Fact]
    public void RemoveDuplicates_AllDuplicates_ReturnsOne()
    {
        int[] nums = { 1, 1, 1, 1 };
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(1, result); 
        // Consider an Assert to also check that nums[0] now contains the only unique value
    }

    [Fact]
    public void RemoveDuplicates_NoDuplicates_ReturnsOriginalLength()
    {
        int[] nums = { 1, 2, 3, 4 };
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(nums.Length, result); 
    }

    [Fact]
    public void RemoveDuplicates_MixedDuplicates_ReturnsCorrectLength()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }; 
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(5, result);  

        // You could also add Asserts to check that first 5 elements of 'nums' are unique 
    }

    [Fact]  
    public void RemoveDuplicates_WithNegatives_WorksCorrectly()
    {
        int[] nums = { -2, -2, -1, 0, 0, 1 };
        int result = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(4, result);
    }
}