using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class DoubleZeroArrayTests
{
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

    [Fact]
    public void DuplicateZeros_ShouldReturnOriginalArray_WhenInputArrayHasNoZeros()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 5 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        Assert.Equal(arr, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldDuplicateZeros_WhenInputArrayHasZeros()
    {
        // Arrange
        int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        int[] expected = { 1, 0, 0, 2, 3, 0, 0, 4 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DuplicateZeros_ShouldHandleConsecutiveZeros()
    {
        // Arrange
        int[] arr = { 1, 0, 0, 2, 0, 3, 0, 4 };

        // Act
        int[] result = DoubleZeroArray.DuplicateZeros(arr);

        // Assert
        int[] expected = { 1, 0, 0, 0, 0, 0, 0, 2 };
        Assert.Equal(expected, result);
    }
}