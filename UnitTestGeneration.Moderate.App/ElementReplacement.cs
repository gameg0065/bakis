namespace UnitTestGeneration.Moderate.App;

// https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 6, co 16

public static class ElementReplacement
{
    #region 16º Replace Elements with Greatest Element on Right Side

    public static int[] ReplaceElements(int[] arr)
    {
        // { 17, 18, 5, 4, 6, 1 };
        var newArray = new int[arr.Length];
        
        if (arr.Length == 1) newArray[0] = -1;
        else
        {
            for (int cont = 0; cont < arr.Length; cont++)
            {
                var result = -1;
                for (int contX = cont; contX < arr.Length; contX++)
                {
                    if (contX + 1 < arr.Length)
                    {
                        if (arr[contX + 1] > result)
                        {
                            result = arr[contX + 1];
                        }   
                    }
                }
                newArray[cont] = result;
            }
        }
        
        return newArray;
    }
    
    #endregion
}