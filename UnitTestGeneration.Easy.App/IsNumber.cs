namespace UnitTestGeneration.Easy.App;

//https://github.com/exc-jdbi/BigPrimeGenerators/blob/main/Code/BigPrimeGenerator/BigPrimeGenerator.cs
// cy = 4, co = 4
public static class IsNumber
{
    public static bool IsNumeric(string number)
    {
        if (string.IsNullOrEmpty(number)) return false;
        foreach (var digit in number)
            if (!int.TryParse(digit.ToString(), out _))
                return false;
        return true;
    }
}