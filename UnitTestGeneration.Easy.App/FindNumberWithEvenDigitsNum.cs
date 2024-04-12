namespace UnitTestGeneration.Easy.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 1, co = 0

public static class FindNumberWithEvenDigitsNum
{
    #region 7º Find Numbers with Even Number of Digits
    public static int FindNumbers(int[] nums)
    {
        return nums.Select(num => num.ToString().ToCharArray()).Count(numCharArray => numCharArray.Length % 2 == 0);
    }
    #endregion
}