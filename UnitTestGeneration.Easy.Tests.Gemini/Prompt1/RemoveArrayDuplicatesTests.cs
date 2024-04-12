using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void ArrayWithDuplicates_RemovesCorrectly()
    {
        int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int expectedLength = 5; 
        int[] expectedArray = new int[] { 0, 1, 2, 3, 4 }; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);

        Assert.Equal(expectedLength, newLength);
        Assert.Equal(expectedArray, nums.Take(expectedLength)); 
    }

    [Fact]
    public void ArrayWithUniqueValues_RemainsUnchanged()
    {
        int[] nums = new int[] { 1, 2, 3, 5, 7 };
        int expectedLength = 5; 
        int[] expectedArray = new int[] { 1, 2, 3, 5, 7 }; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);

        Assert.Equal(expectedLength, newLength);
        Assert.Equal(expectedArray, nums); 
    }
}