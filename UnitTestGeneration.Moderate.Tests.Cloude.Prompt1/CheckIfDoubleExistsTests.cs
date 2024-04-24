using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt1;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[0];

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithDoubleValues_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 1, 2, 4 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNoDoubleValues_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 1, 3, 5 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithZeroValues_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 0, 1, 0, 2 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNegativeValues_ReturnsFalse()
    {
        // Arrange
        int[] arr = { -1, -2, -3 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }
}