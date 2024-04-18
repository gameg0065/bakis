using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt3;

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

    [Theory]
    [InlineData(new int[] { 10, 2, 5, 3 })]
    [InlineData(new int[] { 7, 1, 14, 11 })]
    [InlineData(new int[] { -6, -12, -3, 0 })]
    public void CheckIfExists_NoDoubleExists_ReturnsFalse(int[] arr)
    {
        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(new int[] { 10, 2, 5, 20 })]
    [InlineData(new int[] { 7, 1, 14, 11, 22 })]
    [InlineData(new int[] { -6, -12, -3, -6 })]
    public void CheckIfExists_DoubleExists_ReturnsTrue(int[] arr)
    {
        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_SingleZero_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CheckIfExists_ZeroAndDoubleZero_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[] { 0, 0 };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }
}