using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class ValidateArrayTests
{
    [Fact]
    public void ValidMountainArray_LengthLessThanThree_ReturnsFalse()
    {
        var validator = new ValidateArray();
        var result = validator.ValidMountainArray(new int[] { 1, 2 });
        Assert.False(result);
    }
    
    [Fact]
    public void ValidMountainArray_NoInitialIncrease_ReturnsFalse()
    {
        var validator = new ValidateArray();
        var result = validator.ValidMountainArray(new int[] { 2, 1, 3 }); 
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_NoDecrease_ReturnsFalse()
    {
        var validator = new ValidateArray();
        var result = validator.ValidMountainArray(new int[] { 1, 3, 5, 5 }); 
        Assert.False(result);
    }

    [Fact]
    public void ValidMountainArray_Plateau_ReturnsFalse()
    {
        var validator = new ValidateArray();
        var result = validator.ValidMountainArray(new int[] { 0, 2, 2, 1 });
        Assert.False(result);
    }
    
    [Fact]
    public void ValidMountainArray_ValidArray_ReturnsTrue()
    {
        var validator = new ValidateArray();
        var result = validator.ValidMountainArray(new int[] { 0, 3, 2, 1 }); 
        Assert.True(result);
    }


}