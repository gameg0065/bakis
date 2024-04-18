namespace UnitTestGeneration.Difficult.App;

// https://github.com/IamREGZ/PokerGame/blob/master/Program.cs
// cy = 19, co = 7

public static class CardDeckCreator
{
    static readonly Random rand = new Random();
    
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
    
    // Method to convert numeric value to suit characters.
    public static char ConvertSuit(int num)
    {
        switch (num)
        {
            case 1:
                return 'C';
            case 2:
                return 'D';
            case 3:
                return 'H';
            case 4:
                return 'S';
            default:
                return 'X';
        }
    }
    
    // Method to set card deck in a randomized order.
    public static Card[] SetCardDeck(bool isHand = false)
    {
        string cardDeckInput = "";
        Card[] cardDeck = new Card[isHand ? 5 : 52];

        for (int i = 0; i < cardDeck.Length; i++)
        {
            string card = $"{ConvertValue((rand.Next(1, 14)))}|{ConvertSuit(rand.Next(1, 5))}";

            // Checking for duplicates
            if (!cardDeckInput.Contains(card))
            {
                // Append the card
                cardDeckInput = $"{cardDeckInput}{card}";
            }
            else
            {
                // Try again if duplicate found
                i--;
                continue;
            }

            cardDeck[i] = new Card(card.Split('|')[0], card.Split('|')[1]);
        }

        return cardDeck;
    }
}