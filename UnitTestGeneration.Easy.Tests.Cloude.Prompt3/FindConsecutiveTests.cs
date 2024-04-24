using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class FindConsecutiveTests
{
    [Fact]
    public void FindMaxConsecutiveOnes_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_AllZeros_ReturnsZero()
    {
        // Arrange
        int[] nums = { 0, 0, 0, 0 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_AllOnes_ReturnsArrayLength()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(nums.Length, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_MixedArray_ReturnsMaxConsecutiveOnes()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 1, 0, 1, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_SingleElement_ReturnsElement()
    {
        // Arrange
        int[] nums = { 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(1, result);
    }
}