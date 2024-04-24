using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class FindConsecutiveTests
{
    [Fact]
    public void FindMaxConsecutiveOnes_AllZeros_ReturnsZero()
    {
        // Arrange
        int[] nums = { 0, 0, 0, 0 };
        int expected = 0;

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_AllOnes_ReturnsLengthOfArray()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1 };
        int expected = 4;

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_MixedInput_ReturnsCorrectMaxLength()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 1, 0, 1, 1, 1 };
        int expected = 3;

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_SingleElement_ReturnsCorrectLength()
    {
        // Arrange
        int[] nums = { 1 };
        int expected = 1;

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}