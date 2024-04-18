using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class FindConsecutiveTests
{
    [Fact]
    public void FindMaxConsecutiveOnes_EmptyArray_ReturnsZero()
    {
        int[] nums = new int[0];
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_AllZeros_ReturnsZero()
    {
        int[] nums = { 0, 0, 0, 0 };
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_SingleOne_ReturnsOne()
    {
        int[] nums = { 1 };
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_MultipleSequences_ReturnsCorrectMax()
    {
        int[] nums = { 1, 1, 0, 1, 1, 1 };
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(3, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ConsecutiveAtBeginning_ReturnsCorrectMax()
    {
        int[] nums = { 1, 1, 1, 0, 1 };
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(3, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ConsecutiveAtEnd_ReturnsCorrectMax()
    {
        int[] nums = { 0, 1, 1, 1, 1 };
        var result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(4, result);
    }
}