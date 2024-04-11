namespace UnitTestGeneration.Easy.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 3, co = 3
public static class RemoveArrayDuplicates
{
    public static int RemoveDuplicates(int[] nums)
    {
        // { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        int result = 1;

        foreach (var num in nums)
        {
            if (nums[result - 1] != num)
            {
                nums[result++] = num;
            }
        }

        return result;
    }
}