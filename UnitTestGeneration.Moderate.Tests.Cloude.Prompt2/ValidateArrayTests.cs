using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class ValidateArrayTests
{
    [Fact]
    public void ValidMountainArray_ArrayLengthLessThanThree_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_FirstElementGreaterThanSecond_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 2, 1, 3 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_LastElementGreaterThanSecondLast_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2, 3, 2, 3 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_AdjacentElementsAreEqual_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2, 2, 3 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_NotStrictlyIncreasingOrDecreasing_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2, 3, 2, 2 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_ValidMountainArray_ReturnsTrue()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 0, 2, 3, 2, 1 };

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.True(result);
    }
}