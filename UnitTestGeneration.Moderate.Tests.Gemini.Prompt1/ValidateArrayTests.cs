using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class ValidateArrayTests
{
    [Fact]
    public void ValidMountainArray_ShouldReturnTrueForValidArrays()
    {
        var validator = new ValidateArray();

        Assert.True(validator.ValidMountainArray(new[] { 0, 2, 3, 2, 1 }));
        Assert.True(validator.ValidMountainArray(new[] { 2, 1, 2, 3, 5, 4, 2 }));
    }

    [Fact]
    public void ValidMountainArray_ShouldReturnFalseForInvalidArrays()
    {
        var validator = new ValidateArray();

        Assert.False(validator.ValidMountainArray(new[] { 2, 1 })); // Too short
        Assert.False(validator.ValidMountainArray(new[] { 3, 5, 5 })); // Flat peak
        Assert.False(validator.ValidMountainArray(new[] { 0, 2, 1, 3 })); // Increasing at the end
        Assert.False(validator.ValidMountainArray(new[] { 5, 2, 6, 1 })); // Decreasing at the start
    }

    [Fact]
    public void ValidMountainArray_ShouldHandleEmptyArrays()
    {
        var validator = new ValidateArray();

        Assert.False(validator.ValidMountainArray(new int[] { }));
    }
}