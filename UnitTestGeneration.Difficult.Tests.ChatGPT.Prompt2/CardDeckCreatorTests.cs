using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class CardDeckCreatorTests
{
[Fact]
    public void ConvertValue_ShouldReturnCorrectValue_WhenGivenNumber()
    {
        // Arrange & Act
        string result1 = CardDeckCreator.ConvertValue(1);
        string result2 = CardDeckCreator.ConvertValue(11);
        string result3 = CardDeckCreator.ConvertValue(12);
        string result4 = CardDeckCreator.ConvertValue(13);
        string result5 = CardDeckCreator.ConvertValue(5);

        // Assert
        Assert.Equal("A", result1);
        Assert.Equal("J", result2);
        Assert.Equal("Q", result3);
        Assert.Equal("K", result4);
        Assert.Equal("5", result5);
    }

    [Fact]
    public void ConvertSuit_ShouldReturnCorrectSuit_WhenGivenNumber()
    {
        // Arrange & Act
        char result1 = CardDeckCreator.ConvertSuit(1);
        char result2 = CardDeckCreator.ConvertSuit(2);
        char result3 = CardDeckCreator.ConvertSuit(3);
        char result4 = CardDeckCreator.ConvertSuit(4);
        char result5 = CardDeckCreator.ConvertSuit(5);

        // Assert
        Assert.Equal('C', result1);
        Assert.Equal('D', result2);
        Assert.Equal('H', result3);
        Assert.Equal('S', result4);
        Assert.Equal('X', result5); // Ensure default case returns 'X'
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void SetCardDeck_ShouldCreateDeckOfCorrectSize_WhenGivenIsHand(bool isHand)
    {
        // Arrange & Act
        var result = CardDeckCreator.SetCardDeck(isHand);

        // Assert
        if (isHand)
            Assert.Equal(5, result.Length);
        else
            Assert.Equal(52, result.Length);
    }

    [Fact]
    public void SetCardDeck_ShouldNotContainDuplicates_WhenCalled()
    {
        // Arrange
        bool hasDuplicates = false;

        // Act
        var result = CardDeckCreator.SetCardDeck();

        // Check for duplicates
        var distinctCount = result.Distinct().Count();
        if (distinctCount != result.Length)
            hasDuplicates = true;

        // Assert
        Assert.False(hasDuplicates);
    }
}