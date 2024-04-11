namespace UnitTestGeneration.Easy.App;

//  https://github.com/IamREGZ/PokerGame/blob/master/Program.cs
// cy = 1, co = 0
public static class MultiCardsCheck
{
    public static int CheckForMultiCards(string[] valueCounters, int valueCount)
    {
        return valueCounters.Count(value => Convert.ToInt32(value.Split('|')[1]) == valueCount);
    }
}