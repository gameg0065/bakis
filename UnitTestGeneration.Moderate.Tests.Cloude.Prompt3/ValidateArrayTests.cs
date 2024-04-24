using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class ValidateArrayTests
{
    [Fact]
    public void ValidMountainArray_EmptyArray_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = Array.Empty<int>();

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_LengthLessThanThree_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2 };

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_DecreasingFromStart_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 3, 2, 1 };

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_IncreasingAtEnd_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2, 3 };

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_DuplicateElements_ReturnsFalse()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 1, 2, 3, 2, 1 };

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_ValidArray_ReturnsTrue()
    {
        // Arrange
        var validateArray = new ValidateArray();
        int[] arr = { 0, 2, 3, 2, 1 };

        // Act
        var result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.True(result);
    }
}