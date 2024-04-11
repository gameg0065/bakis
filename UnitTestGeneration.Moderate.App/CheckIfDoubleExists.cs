namespace UnitTestGeneration.Moderate.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 8, co = 22

public static class CheckIfDoubleExists
{
    #region 14º Check If N and Its Double Exist

    public static bool CheckIfExists(int[] arr)
    {
        var index = 0;
        
        if (arr.Length != 0)
        {
            foreach (var item in arr)
            {
                if (item != 0)
                {
                    var find = Array.Find(arr, i => i == item * 2);
                    if (find != 0)
                    {
                        return true;
                    }
                }

                if (item == 0)
                {
                    for (int cont = index + 1; cont < arr.Length; cont++)
                    {
                        if (arr[cont] == item)
                        {
                            return true;
                        }
                    }
                }

                index++;
            }
        
        }
        
        return false;
    }
    #endregion
}