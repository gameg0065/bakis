using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt1;

public class CheckStraightTests
{
    [Theory]
        [InlineData(5, "5")]
        [InlineData(1, "A")]
        [InlineData(11, "J")]
        [InlineData(12, "Q")]
        [InlineData(13, "K")]
        // Add a test for invalid input (e.g., 0, 14) if you want to handle these cases
        public void ConvertValue_ReturnsCorrectString(int input, string expected)
        {
            var result = CheckStraight.ConvertValue(input);
            Assert.Equal(expected, result);
        }

        // Tests for SearchCardValue
        [Fact]
        public void SearchCardValue_FindsExistingCard()
        {
            var cardHand = new CheckStraight.Card[]
            {
                new CheckStraight.Card("7", "H"),
                new CheckStraight.Card("Q", "D")
            };

            var result = CheckStraight.SearchCardValue("Q", cardHand);
            Assert.True(result);
        }

        [Fact]
        public void SearchCardValue_DoesNotFindNonExistingCard()
        {
            var cardHand = new CheckStraight.Card[]
            {
                new CheckStraight.Card("7", "H"),
                new CheckStraight.Card("Q", "D")
            };

            var result = CheckStraight.SearchCardValue("10", cardHand);
            Assert.False(result);
        }

        // Tests for CheckForStraight
        [Fact]
        public void CheckForStraight_IdentifiesStraight()
        {
            var cardHand = new CheckStraight.Card[]
            {
                new CheckStraight.Card("10", "H"),
                new CheckStraight.Card("J", "D"),
                new CheckStraight.Card("Q", "C"),
                new CheckStraight.Card("K", "H"),
                new CheckStraight.Card("A", "S")
            };

            var result = CheckStraight.CheckForStraight(cardHand);
            Assert.True(result);
        }

        [Fact]
        public void CheckForStraight_IdentifiesNonStraight()
        {
            var cardHand = new CheckStraight.Card[]
            {
                new CheckStraight.Card("2", "H"),
                new CheckStraight.Card("4", "D"),
                new CheckStraight.Card("Q", "C"),
                new CheckStraight.Card("K", "H"),
                new CheckStraight.Card("A", "S")
            };

            var result = CheckStraight.CheckForStraight(cardHand);
            Assert.False(result);
        }
}