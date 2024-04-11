using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class DoubleZeroArrayTests
{
    [Fact]
    public void TestWithZeros()
    {
        int[] input = { 1, 0, 2, 3, 0, 4, 5, 0 };
        int[] expected = { 1, 0, 0, 2, 3, 0, 0, 4 };

        var result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestWithoutZeros()
    {
        int[] input = { 1, 2, 3 };
        int[] expected = { 1, 2, 3 };

        var result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestAllZeros()
    {
        int[] input = { 0, 0, 0, 0 };
        int[] expected = { 0, 0, 0, 0 };

        var result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] input = new int[0];
        int[] expected = new int[0];

        var result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNullArray()
    {
        int[] input = null;
        Assert.Throws<ArgumentNullException>(() => DoubleZeroArray.DuplicateZeros(input));
    }
}