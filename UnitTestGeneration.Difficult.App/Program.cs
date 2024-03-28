using UnitTestGeneration.Difficult.App;

internal abstract class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LoanApplication.IsFamilyApplicableForLoad(new Tuple<int, int>(21, 42), new Tuple<int, int>(2000, 1230)));
    }
}