using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt1;

public class ValidateArrayTests
{
    [Theory]
    [InlineData(new[] { 0, 2, 3, 2, 1 }, true)]
    [InlineData(new[] { 0, 2, 3, 2, 1, 0 }, true)]
    [InlineData(new[] { 2, 1 }, false)]
    [InlineData(new[] { 3, 5, 5 }, false)]
    [InlineData(new[] { 0, 3, 2, 1 }, true)]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, false)]
    public void ValidMountainArray_ReturnsExpectedResult(int[] arr, bool expectedResult)
    {
        // Arrange
        var validateArray = new ValidateArray();

        // Act
        bool result = validateArray.ValidMountainArray(arr);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}