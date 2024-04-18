using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void EmptyArray_ReturnsFalse()
    {
        int[] arr = new int[0]; // Empty array
        bool result = CheckIfDoubleExists.CheckIfExists(arr);
        Assert.False(result);
    }

    [Fact]
    public void ArrayWithDouble_ReturnsTrue()
    {
        int[] arr = { 3, 1, 7, 6 }; 
        bool result = CheckIfDoubleExists.CheckIfExists(arr);
        Assert.True(result);
    }

    [Fact] 
    public void ArrayWithoutDouble_ReturnsFalse()
    {
        int[] arr = { 1, 3, 5, 9 };
        bool result = CheckIfDoubleExists.CheckIfExists(arr);
        Assert.False(result);
    }

    [Fact]
    public void ArrayWithMultipleZeros_ReturnsTrue()
    {
        int[] arr = { 0, 0, 3 };
        bool result = CheckIfDoubleExists.CheckIfExists(arr);
        Assert.True(result);
    }

    [Fact]
    public void ArrayWithNegativeNumbers_ReturnsCorrectly()
    {
        int[] arr = { -4, 1, -8 };
        bool result = CheckIfDoubleExists.CheckIfExists(arr);
        Assert.True(result);
    }
}