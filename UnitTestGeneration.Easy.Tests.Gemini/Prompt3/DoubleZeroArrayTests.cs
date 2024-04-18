using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class DoubleZeroArrayTests
{
    [Fact]
    public void DuplicateZeros_EmptyArray_ReturnsEmptyArray()
    {
        int[] arr = new int[0];
        int[] result = DoubleZeroArray.DuplicateZeros(arr);
        Assert.Equal(new int[0], result); // Or use Assert.Empty(result)
    }

    [Fact]
    public void DuplicateZeros_NoZeros_ReturnsOriginalArray()
    {
        int[] arr = { 1, 2, 5, 8 };
        int[] result = DoubleZeroArray.DuplicateZeros(arr);
        Assert.Equal(arr, result);
    }

    [Fact]
    public void DuplicateZeros_SingleZero_DuplicatesCorrectly()
    {
        int[] arr = { 1, 0, 3 };
        int[] expected = { 1, 0, 0, 3 };
        int[] result = DoubleZeroArray.DuplicateZeros(arr);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_MultipleZeros_DuplicatesCorrectly()
    {
        int[] arr = { 1, 0, 2, 3, 0, 4 };
        int[] expected = { 1, 0, 0, 2, 3, 0, 0, 4 };
        int[] result = DoubleZeroArray.DuplicateZeros(arr);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ZerosAtEnd_DuplicatesCorrectly()
    {
        int[] arr = { 1, 2, 0, 0 };
        int[] expected = { 1, 2, 0, 0 }; 
        int[] result = DoubleZeroArray.DuplicateZeros(arr);
        Assert.Equal(expected, result);
    }
}