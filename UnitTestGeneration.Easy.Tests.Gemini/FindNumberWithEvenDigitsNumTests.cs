using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class FindNumberWithEvenDigitsNumTests
{
    [Fact]
    public void TestWithEvenDigitNumbers()
    {
        int[] nums = { 12, 345, 2, 6, 7896 };
        int expected = 2;  // 12 and 7896 have even number of digits

        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestWithoutEvenDigitNumbers()
    {
        int[] nums = { 555, 901, 4823 };
        int expected = 0; 

        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestWithSingleDigitNumbers()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int expected = 0; 

        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] nums = new int[0];
        int expected = 0;

        int result = FindNumberWithEvenDigitsNum.FindNumbers(nums);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNullArray()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => FindNumberWithEvenDigitsNum.FindNumbers(nums));
    }
}