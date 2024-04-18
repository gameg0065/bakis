using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.ChatGPT.Prompt2;

public class CheckIfDoubleExistsTests
{
    [Fact]
    public void CheckIfExists_ReturnsFalse_ForEmptyArray()
    {
        // Arrange
        int[] arr = new int[] { };

        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(new int[] { 5 }, false)]
    [InlineData(new int[] { 0 }, false)]
    [InlineData(new int[] { -5 }, false)]
    [InlineData(new int[] { 0, 0 }, true)]
    [InlineData(new int[] { 5, 10 }, true)]
    [InlineData(new int[] { -5, -10 }, true)]
    [InlineData(new int[] { 0, 5 }, true)]
    [InlineData(new int[] { 5, 0 }, true)]
    [InlineData(new int[] { 5, 5 }, true)]
    [InlineData(new int[] { -5, -5 }, true)]
    public void CheckIfExists_ReturnsExpectedResult_ForDifferentArrays(int[] arr, bool expectedResult)
    {
        // Act
        bool result = CheckIfDoubleExists.CheckIfExists(arr);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}