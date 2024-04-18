using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class FindNumberWithEvenDigitsNumTests
{
    [Fact]
    public void FindNumbers_EmptyArray_ReturnsZero()
    {
        int[] nums = new int[0];
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindNumbers_AllEvenDigitCounts_ReturnsCorrectCount()
    {
        int[] nums = { 12, 444, 7896 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(2, result); // 12 and 7896 have even digit counts
    }

    [Fact]
    public void FindNumbers_NoEvenDigitCounts_ReturnsZero()
    {
        int[] nums = { 555, 901, 1771 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindNumbers_SingleDigitNumbers_AreCounted()
    {
        int[] nums = { 2, 5, 8 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(3, result); // All single-digit numbers are considered 
    }

    [Fact]
    public void FindNumbers_WithZero_CountsAsEven()
    {
        int[] nums = { 0, 123, 1000 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(2, result); // 0 and 1000 have even digit counts
    }
}