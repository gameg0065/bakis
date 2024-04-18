using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class RemoveArrayDuplicatesTests
{
    [Fact]
    public void TestWithDuplicates()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int expectedLength = 5; 
        int[] expectedArray = { 0, 1, 2, 3, 4 }; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(expectedLength, newLength);
        Assert.Equal(expectedArray, nums.Take(expectedLength)); 
    }

    [Fact]
    public void TestWithoutDuplicates()
    {
        int[] nums = { 1, 2, 3, 4 };
        int expectedLength = 4; 
        int[] expectedArray = { 1, 2, 3, 4 }; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(expectedLength, newLength);
        Assert.Equal(expectedArray, nums.Take(expectedLength)); 
    }

    [Fact]
    public void TestAllDuplicates()
    {
        int[] nums = { 2, 2, 2, 2 };
        int expectedLength = 1; 
        int[] expectedArray = { 2 }; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(expectedLength, newLength);
        Assert.Equal(expectedArray, nums.Take(expectedLength)); 
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] nums = new int[0];
        int expectedLength = 0; 

        int newLength = RemoveArrayDuplicates.RemoveDuplicates(nums);
        Assert.Equal(expectedLength, newLength);
    }

    [Fact]
    public void TestNullArray()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => RemoveArrayDuplicates.RemoveDuplicates(nums));
    }
}