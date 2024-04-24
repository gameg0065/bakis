using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt3;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] arr = { };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNonZeroValuesAndDoubleExists_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4, 8 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNonZeroValuesAndDoubleDoesNotExist_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 1, 3, 5, 7, 9 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithZeroAndNonZeroValues_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 0, 1, 2, 3, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithOnlyZeroes_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 0, 0, 0, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }
}