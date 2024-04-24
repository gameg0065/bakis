using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class FindNumberWithEvenDigitsNumTests
{
[Fact]
    public void FindNumbers_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithNoEvenDigitNumbers_ReturnsZero()
    {
        // Arrange
        int[] nums = { 1, 23, 456 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithAllEvenDigitNumbers_ReturnsArrayLength()
    {
        // Arrange
        int[] nums = { 12, 3456, 78 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(nums.Length, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithMixedDigitNumbers_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { 12, 345, 6789, 1 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithNegativeNumbers_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { -12, 345, -6789, 1 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithZero_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { 0, 12, 345 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithMaxValue_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { int.MaxValue, 12, 345 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithMinValue_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { int.MinValue, 12, 345 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(1, result);
    }
}