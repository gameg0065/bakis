using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class ElementReplacementTests
{
    [Fact]
    public void SingleElementArray_ReturnsMinusOne()
    {
        int[] arr = { 5 };
        int[] expectedResult = { -1 };
        int[] result = ElementReplacement.ReplaceElements(arr);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TypicalArray_ReplacesElementsCorrectly()
    {
        int[] arr = { 17, 18, 5, 4, 6, 1 };
        int[] expectedResult = { 18, 6, 6, 6, 1, -1 };
        int[] result = ElementReplacement.ReplaceElements(arr);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ArrayWithEqualValues_ReplacesElementsCorrectly()
    {
        int[] arr = { 5, 5, 5, 2 };
        int[] expectedResult = { 5, 5, 2, -1 };
        int[] result = ElementReplacement.ReplaceElements(arr);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ArrayWithDescendingElements_ReplacesElementsCorrectly()
    {
        int[] arr = { 7, 5, 3, 1 };
        int[] expectedResult = { 5, 3, 1, -1 };
        int[] result = ElementReplacement.ReplaceElements(arr);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void EmptyArray_ReturnsEmptyArray() 
    {
        int[] arr = new int[0];
        int[] expectedResult = new int[0]; 
        int[] result = ElementReplacement.ReplaceElements(arr);
        Assert.Equal(expectedResult, result);
    }
}