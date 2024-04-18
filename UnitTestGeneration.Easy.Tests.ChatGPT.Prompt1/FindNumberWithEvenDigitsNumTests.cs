using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class FindNumberWithEvenDigitsNumTests
{
    [Fact]
    public void FindNumbers_ShouldReturnZero_WhenArrayIsEmpty()
    {
        // Arrange
        int[] nums = { };

        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(0, result);
    }
    

    [Theory]
    [InlineData(new int[] { 1, 22, 333, 4444 }, 2)] // Two numbers with even digits: 22, 4444
    [InlineData(new int[] { 11, 3333, 55555 }, 0)] // No numbers with even digits
    [InlineData(new int[] { 10, 100, 1000, 10000 }, 4)] // All numbers have even digits
    public void FindNumbers_ShouldReturnCorrectCount(int[] nums, int expected)
    {
        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}