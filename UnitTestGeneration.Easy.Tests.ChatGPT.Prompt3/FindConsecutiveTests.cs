using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class FindConsecutiveTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 0, 1, 1, 1, 0 }, 3)] // Mixed sequence
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 5)] // All ones
    [InlineData(new int[] { 0, 0, 0, 0 }, 0)] // All zeros
    [InlineData(new int[] { 1 }, 1)] // Single element array with one
    [InlineData(new int[] { 0 }, 0)] // Single element array with zero
    [InlineData(new int[] { }, 0)] // Empty array
    public void FindMaxConsecutiveOnes_ShouldReturnCorrectResult_ForDifferentArrays(int[] nums, int expected)
    {
        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}