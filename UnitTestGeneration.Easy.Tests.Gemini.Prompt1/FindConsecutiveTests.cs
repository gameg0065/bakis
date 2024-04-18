using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class FindConsecutiveTests
{
    [Fact]
    public void EmptyArray_ReturnsZero()
    {
        int[] nums = new int[] {};
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void AllZeros_ReturnsZero()
    {
        int[] nums = new int[] { 0, 0, 0, 0 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleOne_ReturnsOne()
    {
        int[] nums = new int[] { 1 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void ConsecutiveAtBeginning_ReturnsCorrectCount()
    {
        int[] nums = new int[] { 1, 1, 0, 1 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(2, result);
    }

    [Fact]
    public void ConsecutiveAtEnd_ReturnsCorrectCount()
    {
        int[] nums = new int[] { 0, 1, 1, 1 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(3, result);
    }

    [Fact]
    public void ConsecutiveInMiddle_ReturnsCorrectCount()
    {
        int[] nums = new int[] { 0, 1, 1, 0, 1, 1, 1 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(3, result);
    }

    [Fact]
    public void MultipleGroups_ReturnsMaxCount()
    {
        int[] nums = new int[] { 1, 1, 0, 1, 1, 1, 0, 1 };
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(3, result);
    }
}