using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class DoubleZeroArrayTests
{
    [Fact]
    public void DuplicateZeros_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[0];

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithoutZeros_ReturnsOriginalArray()
    {
        // Arrange
        int[] input = { 1, 2, 3 };
        int[] expected = { 1, 2, 3 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithZeros_DuplicatesZeros()
    {
        // Arrange
        int[] input = { 1, 0, 2, 3, 0, 4, 5, 0 };
        int[] expected = { 1, 0, 0, 2, 3, 0, 0, 4, 5, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithTrailingZeros_DuplicatesZerosUntilEnd()
    {
        // Arrange
        int[] input = { 1, 2, 3, 0, 0, 0 };
        int[] expected = { 1, 2, 3, 0, 0, 0, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithLengthOverflow_TruncatesOutput()
    {
        // Arrange
        int[] input = { 1, 0, 2, 0, 3, 0, 4, 0, 5 };
        int[] expected = { 1, 0, 0, 2, 0, 0, 3, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }
}