using UnitTestGeneration.Moderate.App;

internal abstract class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LoanApplication.CanGetFamilyLoan(28, 19));
        // Console.WriteLine(LoanApplication.CanGetFamilyLoan(20, 23, true));
    }
}