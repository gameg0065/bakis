using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_ReturnsTrue_WhenDoubleExists()
    {
        // Arrange
        int[] arr = { 10, 2, 5, 3 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ReturnsFalse_WhenDoubleDoesNotExist()
    {
        // Arrange
        int[] arr = { 7, 1, 14, 11 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ReturnsFalse_WhenArrayIsEmpty()
    {
        // Arrange
        int[] arr = { };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ReturnsFalse_WhenArrayContainsOnlyZeros()
    {
        // Arrange
        int[] arr = { 0, 0, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CheckIfExists_ReturnsTrue_WhenArrayContainsZeroAndItsDouble()
    {
        // Arrange
        int[] arr = { 0, 1, 2, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ReturnsFalse_WhenArrayContainsNoZeroButDoubleZero()
    {
        // Arrange
        int[] arr = { 4, 2, 8, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }
}