using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class DoubleZeroArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 0, 0, 1 }, new int[] { 0, 0, 0, 0, 1 })]
    public void DuplicateZeros_ModifiesArrayCorrectly(int[] input, int[] expected) 
    {
        int[] result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EmptyArray_ReturnsEmptyArray()
    {
        int[] input = new int[] { };
        int[] expected = new int[] { };

        int[] result = DoubleZeroArray.DuplicateZeros(input);
        Assert.Equal(expected, result);
    }
}