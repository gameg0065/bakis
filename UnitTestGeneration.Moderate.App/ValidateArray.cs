namespace UnitTestGeneration.Moderate.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 10, co = 9

public class ValidateArray
{
    #region 15º ValidMountainArray

    public bool ValidMountainArray(int[] arr)
    {
        // new[] { 0,2,3,2,1};
        if (arr.Length < 3 || arr[0] > arr[1] || arr[^1] > arr[^2]) return false;

        bool incresing = true;
        int previous = -1;

        foreach (var item in arr)
        {
            if (previous == item) return false;
            else if (incresing && previous > item) incresing = false;
            else if (!incresing && previous < item) return false;

            previous = item;
        }

        return true;
    }

    #endregion
}