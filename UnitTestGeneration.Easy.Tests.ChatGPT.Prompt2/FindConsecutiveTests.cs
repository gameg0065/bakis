using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class FindConsecutiveTests
{
    [Fact]
    public void FindMaxConsecutiveOnes_ShouldReturnZero_WhenArrayIsEmpty()
    {
        // Arrange
        int[] nums = { };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { 0, 0, 0, 0, 0 })]
    [InlineData(new int[] { 0, 1, 0, 1, 0 })]
    [InlineData(new int[] { 0, 0, 0, 0, 1 })]
    public void FindMaxConsecutiveOnes_ShouldReturnZero_WhenNoOnes(int[] nums)
    {
        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 0, 1, 1, 1 }, 3)] // Three consecutive ones
    [InlineData(new int[] { 0, 1, 1, 1, 1, 0 }, 4)] // Four consecutive ones
    [InlineData(new int[] { 1, 0, 1, 1, 1, 1 }, 4)] // Four consecutive ones
    public void FindMaxConsecutiveOnes_ShouldReturnCorrectMaxConsecutiveOnes(int[] nums, int expected)
    {
        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ShouldHandleSingleOne()
    {
        // Arrange
        int[] nums = { 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ShouldHandleNoOnesAtEnd()
    {
        // Arrange
        int[] nums = { 1, 1, 0, 1, 0 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(2, result);
    }
}