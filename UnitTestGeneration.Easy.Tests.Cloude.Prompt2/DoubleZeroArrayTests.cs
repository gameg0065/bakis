using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class DoubleZeroArrayTests
{
[Fact]
    public void DuplicateZeros_ArrayWithoutZeros_ReturnsOriginalArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4 };
        int[] expected = { 1, 2, 3, 4 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithSingleZero_ReturnsArrayWithDuplicateZero()
    {
        // Arrange
        int[] input = { 1, 0, 2, 3 };
        int[] expected = { 1, 0, 0, 2, 3 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithMultipleZeros_ReturnsArrayWithDuplicateZeros()
    {
        // Arrange
        int[] input = { 1, 0, 2, 0, 0, 3 };
        int[] expected = { 1, 0, 0, 2, 0, 0, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ArrayWithTrailingZeros_ReturnsArrayWithDuplicateZeros()
    {
        // Arrange
        int[] input = { 1, 2, 0, 0 };
        int[] expected = { 1, 2, 0, 0, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        int[] expected = Array.Empty<int>();

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_MaximumLengthArray_ReturnsCorrectResult()
    {
        // Arrange
        int[] input = Enumerable.Range(1, 100000).ToArray();
        int[] expected = Enumerable.Range(1, 100000).Concat(Enumerable.Repeat(0, 100000)).ToArray();

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        Assert.Equal(expected.Take(100000), result);
    }
}