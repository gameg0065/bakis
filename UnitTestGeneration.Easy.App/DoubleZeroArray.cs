namespace UnitTestGeneration.Easy.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 3, co = 4

public static class DoubleZeroArray
{
    public static int[] DuplicateZeros(int[] arr)
    {
        var listArray = new List<int>();
        var doubleZero = new int[] {0, 0};

        for (int i = 0; listArray.Count < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                listArray.Add(arr[i]);
            }
            else
            {
                listArray.AddRange(doubleZero);
            }
        }

        return listArray.ToArray();
    }
}