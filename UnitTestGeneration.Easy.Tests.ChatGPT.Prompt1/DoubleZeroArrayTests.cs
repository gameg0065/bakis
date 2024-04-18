using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class DoubleZeroArrayTests
{
    [Fact]
    public void DuplicateZeros_ShouldDuplicateZerosCorrectly()
    {
        // Arrange
        int[] input = { 1, 0, 2, 3, 0, 4, 5, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        int[] expected = { 1, 0, 0, 2, 3, 0, 0, 4 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        int[] expected = { };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldNotDuplicateZeroAtEnd()
    {
        // Arrange
        int[] input = { 1, 2, 3 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        int[] expected = { 1, 2, 3 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldDuplicateZerosAtTheEnd()
    {
        // Arrange
        int[] input = { 0, 1, 2, 3 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(input);

        // Assert
        int[] expected = { 0, 0, 1, 2 };
        Assert.Equal(expected, result);
    }
}