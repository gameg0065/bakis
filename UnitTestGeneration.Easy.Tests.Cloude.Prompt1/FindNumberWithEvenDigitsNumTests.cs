using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class FindNumberWithEvenDigitsNumTests
{
    [Fact]
    public void FindNumbers_AllEvenDigitNumbers_ReturnsLengthOfArray()
    {
        // Arrange
        int[] nums = { 12, 34, 5678 };
        int expected = 3;

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindNumbers_AllOddDigitNumbers_ReturnsZero()
    {
        // Arrange
        int[] nums = { 1, 23, 457 };
        int expected = 0;

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindNumbers_MixedDigitNumbers_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { 12, 345, 678, 9 };
        int expected = 2;

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindNumbers_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] nums = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindNumbers_SingleDigitNumber_ReturnsZero()
    {
        // Arrange
        int[] nums = { 5 };
        int expected = 0;

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}