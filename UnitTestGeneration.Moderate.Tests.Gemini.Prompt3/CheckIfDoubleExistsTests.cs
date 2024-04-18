using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithoutDoubles_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[] { 1, 3, 5, 7 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithDouble_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 10, 2, 5, 3 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ArrayWithMultipleZeroes_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 0, 7, 0, 3 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }
}