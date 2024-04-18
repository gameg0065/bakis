using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        var result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void CheckIfExists_ArrayWithDouble_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 3, 6, 1, 2 };

        // Act
        var result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void CheckIfExists_ArrayWithoutDouble_ReturnsFalse()
    {
        // Arrange
        int[] arr = new int[] { 1, 5, 3, 7 };

        // Act
        var result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void CheckIfExists_MultipleZeros_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 0, 1, 3, 0 };

        // Act
        var result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void CheckIfExists_ZeroAsDouble_ReturnsTrue()
    {
        // Arrange
        int[] arr = new int[] { 0, 2, 4 };

        // Act
        var result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.True(result);
    }
    
}