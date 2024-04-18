namespace UnitTestGeneration.Difficult.App;

// https://github.com/IamREGZ/PokerGame/blob/master/Program.cs
// cy = 19, co 15

public static class CheckStraight
{
    public sealed class Card
    {
        #region Properties
        public string CardValue { get; set; }

        public string CardSuit { get; set; }
        #endregion

        #region Constructors
        public Card(string value, string suit)
        {
            CardValue = value;
            CardSuit = suit;
        }
        #endregion
    }
    
    public static string ConvertValue(int num)
    {
        switch (num)
        {
            case 1:
                return "A";
            case 11:
                return "J";
            case 12:
                return "Q";
            case 13:
                return "K";
            default:
                return num.ToString();
        }
    }
    
    public static bool CheckForStraight(Card[] cardHand)
    {
        int currentValue = 0, endValue = 0;

        // Check if there's an ace (can be the lowest or highest).
        if (SearchCardValue("A", cardHand))
        {
            if (SearchCardValue("2", cardHand))
            {
                // A and 2 are in the hand.
                currentValue = 3;
                endValue = 5;
            }
            else if (SearchCardValue("K", cardHand))
            {
                // A and K are in the hand.
                currentValue = 10;
                endValue = 12;
            }
            else
            {
                // Since ace has no consecutive card value, it is automatically not a straight.
                return false;
            }
        }
        else
        {
            // If there's no ace, search for the lowest card value.
            for (int i = 2; i <= 13; i++)
            {
                if (SearchCardValue(ConvertValue(i), cardHand))
                {
                    currentValue = i + 1;
                    endValue = i + 4;
                    break;
                }
            }
        }

        for (int i = currentValue; i <= endValue; i++)
        {
            if (!SearchCardValue(ConvertValue(i), cardHand)) return false;
        }

        return true;
    }
    
    public static bool SearchCardValue(string value, Card[] cardHand)
    {
        return cardHand.Count(card => card.CardValue == value) > 0;
    }
}