namespace UnitTestGeneration.Easy.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 4, co = 6 

public static class FindConsecutive
{
    #region 6º Max Consecutives Ones
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        var maxLentgh = new List<int>();
        var maxNumber = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                maxNumber += 1;
            }
            else
            {
                maxLentgh.Add(maxNumber);
                maxNumber = 0;
            }
            if (i == nums.Length - 1)
            {
                maxLentgh.Add(maxNumber);
            }
        }
        return maxLentgh.Max();
    }
    #endregion
}