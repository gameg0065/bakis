namespace UnitTestGeneration.Easy.App;

//  https://github.com/VictorDolzan/LeetCode/blob/main/LeetCode/Exercicios.cs
// cy = 1, co = 0

public class CheckForPalindrome
{
    public bool IsPalindrome(int x)
    {
        string first = x.ToString();
        char[] charArr = first.ToCharArray();
        char[] reverseArr = first.ToCharArray();
        
        Array.Reverse(reverseArr);

        return charArr.SequenceEqual(reverseArr);
    }
}