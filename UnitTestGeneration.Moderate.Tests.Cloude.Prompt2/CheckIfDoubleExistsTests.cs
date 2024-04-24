using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Cloude.Prompt2;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] arr = Array.Empty<int>();

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNonZeroDoubleExists_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 6 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithZeroDoubleExists_ReturnsTrue()
    {
        // Arrange
        int[] arr = { 0, 1, 0, 2 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNoDoubleExists_ReturnsFalse()
    {
        // Arrange
        int[] arr = { 1, 2, 3, 4 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int[] arr1 = { -1, 2, -2 };
        int[] arr2 = { -1, -2, 3, 4 };

        // Act
        bool result1 = CheckIfDoubleExists.CheckIfExists(arr1);
        bool result2 = CheckIfDoubleExists.CheckIfExists(arr2);

        // Assert
        Assert.True(result1);
        Assert.False(result2);
    }
}