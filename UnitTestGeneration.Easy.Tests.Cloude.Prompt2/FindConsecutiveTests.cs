using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

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
    public void FindMaxConsecutiveOnes_ArrayWithoutOnes_ReturnsZero()
    {
        // Arrange
        int[] nums = { 0, 0, 0 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ArrayWithAllOnes_ReturnsLengthOfArray()
    {
        // Arrange
        int[] nums = { 1, 1, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(nums.Length, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ArrayWithIntermittentOnes_ReturnsMaxConsecutiveOnes()
    {
        // Arrange
        int[] nums = { 1, 0, 1, 1, 0, 1, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ArrayWithLeadingOnes_ReturnsMaxConsecutiveOnes()
    {
        // Arrange
        int[] nums = { 1, 1, 0, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void FindMaxConsecutiveOnes_ArrayWithTrailingOnes_ReturnsMaxConsecutiveOnes()
    {
        // Arrange
        int[] nums = { 0, 1, 1, 1, 1 };

        // Act
        int result = FindConsecutive.FindMaxConsecutiveOnes(nums);

        // Assert
        Assert.Equal(4, result);
    }
}