namespace UnitTestGeneration.Moderate.App;
// https://github.com/Hahhhayam/spendings-manager/blob/dev/BLL/Extensions/EnumerableExtensions.cs
// cy = 8, co = 8
public static class EnumerableExtensions
{
    public static bool SequenceEqualOrderIgnore<T>(this IEnumerable<T> first, IEnumerable<T> second, IEqualityComparer<T> comparer)
    {
        if (first is null || second is null) return false;

        Dictionary<T, int>? dict = new Dictionary<T, int>(comparer);
        foreach (T element in first)
        {
            dict.TryGetValue(element, out int count);
            dict[element] = count + 1;
        }

        foreach (T element in second)
        {
            if (!dict.TryGetValue(element, out int count))
                return false;
            else if (--count == 0)
                dict.Remove(element);
            else
                dict[element] = count;
        }

        return dict.Count == 0;
    }

    public static bool SequenceEqualOrderIgnore<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        return SequenceEqualOrderIgnore<T>(first, second, EqualityComparer<T>.Default);
    }
}