using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class DoubleZeroArrayTests
{
    [Fact]
    public void DuplicateZeros_ShouldReturnUnchangedArray_WhenNoZerosPresent()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Equal(arr, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldReturnArrayWithZerosDuplicated_WhenZerosPresent()
    {
        // Arrange
        int[] arr = { 1, 0, 2, 3, 0, 4, 5 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Equal(new int[] { 1, 0, 0, 2, 3, 0, 0, 4, 5 }, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldReturnArrayWithZerosDuplicatedOnlyOnce_WhenConsecutiveZerosPresent()
    {
        // Arrange
        int[] arr = { 1, 0, 0, 2, 0, 3, 4 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Equal(new int[] { 1, 0, 0, 0, 0, 2, 0, 3, 4 }, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldReturnArrayWithDuplicatedZerosAtEnd_WhenZerosAtEndPresent()
    {
        // Arrange
        int[] arr = { 1, 2, 0, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Equal(new int[] { 1, 2, 0, 0 }, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldReturnEmptyArray_WhenInputArrayIsEmpty()
    {
        // Arrange
        int[] arr = { };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Empty(result);
    }
}