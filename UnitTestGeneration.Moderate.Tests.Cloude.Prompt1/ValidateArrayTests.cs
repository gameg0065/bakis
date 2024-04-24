using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class ValidateArrayTests
{
    private readonly ValidateArray _validateArray;

    public ValidateArrayTests()
    {
        _validateArray = new ValidateArray();
    }

    [Fact]
    public void ValidMountainArray_ArrayLengthLessThan3_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 1, 2 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_FirstElementGreaterThanSecond_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 2, 1, 3, 2, 1 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_LastElementGreaterThanSecondToLast_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 0, 2, 3, 2, 3 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_AdjacentElementsEqual_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 0, 2, 3, 2, 2, 1 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_ValidArray_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 0, 2, 3, 2, 1 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ValidMountainArray_ArrayWithSingleElement_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 1 };

        // Act
        bool result = _validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }
}