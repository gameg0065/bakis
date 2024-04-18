using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

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
    [InlineData(new int[] { 1, 1, 1, 1, 1 })]
    public void FindMaxConsecutiveOnes_ShouldReturnZero_WhenNoOnes(int[] nums)
    {
        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 0, 1, 1, 1 })]
    [InlineData(new int[] { 0, 1, 1, 1, 1, 0 })]
    [InlineData(new int[] { 1, 0, 1, 1, 1, 1 })]
    public void FindMaxConsecutiveOnes_ShouldReturnCorrectMaxConsecutiveOnes(int[] nums)
    {
        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(4, result);
    }
}