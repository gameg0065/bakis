namespace UnitTestGeneration.Easy.App;

public static class MultiCardsCheck
{
    private static int CheckForMultiCards(string[] valueCounters, int valueCount)
    {
        return valueCounters.Count(value => Convert.ToInt32(value.Split('|')[1]) == valueCount);
    }
}