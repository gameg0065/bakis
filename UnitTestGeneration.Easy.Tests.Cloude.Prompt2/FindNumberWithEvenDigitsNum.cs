namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class FindNumberWithEvenDigitsNum
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
    public void FindNumbers_ArrayWithOnlyOddDigitNumbers_ReturnsZero()
    {
        // Arrange
        int[] nums = { 1, 13, 105, 7 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithOnlyEvenDigitNumbers_ReturnsArrayLength()
    {
        // Arrange
        int[] nums = { 12, 34, 5678 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(nums.Length, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithMixedDigitNumbers_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { 12, 345, 2, 6, 7896 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(3, result);
    }

    private static int FindNumbers(int[] nums)
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void FindNumbers_ArrayWithNegativeNumbers_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { -12, 345, -678, 9 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void FindNumbers_ArrayWithZero_ReturnsCorrectCount()
    {
        // Arrange
        int[] nums = { 0, 12, 34 };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(3, result);
    }
}