using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class FindConsecutiveTests
{
    [Fact]
    public void TestWithConsecutiveOnes()
    {
        int[] nums = { 1, 1, 0, 1, 1, 1 };
        int expected = 3;

        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestWithoutConsecutiveOnes()
    {
        int[] nums = { 0, 0, 0 };
        int expected = 0;

        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestAllOnes()
    {
        int[] nums = { 1, 1, 1, 1 };
        int expected = 4;

        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSingleOne()
    {
        int[] nums = { 1 };
        int expected = 1;

        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] nums = new int[0];
        int expected = 0;

        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNullArray()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => FindConsecutive.FindMaxConsecutiveOnes(nums));
    }
}