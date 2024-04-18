using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class FindNumberWithEvenDigitsNumTests
{
    [Fact]
    public void EmptyArray_ReturnsZero()
    {
        int[] nums = new int[] { };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleEvenDigitNumber_ReturnsOne()
    {
        int[] nums = new int[] { 1234 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(1, result);
    }

    [Fact]
    public void SingleOddDigitNumber_ReturnsZero()
    {
        int[] nums = new int[] { 123 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(0, result);
    }

    [Fact]
    public void MixedNumbers_ReturnsCorrectCount()
    {
        int[] nums = new int[] { 12, 345, 2, 654321 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(2, result); // 12 and 654321 have even digits
    }

    [Fact]
    public void LargeNumbers_ReturnsCorrectCount()
    {
        int[] nums = new int[] { 1234567, 87654321, 4444 };
        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(2, result); 
    }
}