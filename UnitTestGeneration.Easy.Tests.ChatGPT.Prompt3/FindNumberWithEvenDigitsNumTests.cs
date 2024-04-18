using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class FindNumberWithEvenDigitsNumTests
{
    [Theory]
    [InlineData(new int[] { 12, 345, 2, 6, 7896 }, 3)] // Three numbers with even number of digits
    [InlineData(new int[] { 555, 901, 482, 1771 }, 2)] // Two numbers with even number of digits
    [InlineData(new int[] { 7, 7, 777, 7777 }, 2)] // Two numbers with even number of digits
    [InlineData(new int[] { -12, -345, -2, -6, -7896 }, 3)] // Three negative numbers with even number of digits
    [InlineData(new int[] { -555, -901, -482, -1771 }, 2)] // Two negative numbers with even number of digits
    [InlineData(new int[] { -7, -7, -777, -7777 }, 2)] // Two negative numbers with even number of digits
    [InlineData(new int[] { 1, 22, 333, 4444 }, 0)] // No numbers with even number of digits
    [InlineData(new int[] { 123, 456, 789, 987654 }, 0)] // No numbers with even number of digits
    [InlineData(new int[] { 0, 0, 0, 0 }, 4)] // All numbers with even number of digits
    public void FindNumbers_ShouldReturnCorrectCount_ForDifferentArrays(int[] nums, int expected)
    {
        // Act
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}