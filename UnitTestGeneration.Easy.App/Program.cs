// See https://aka.ms/new-console-template for more information

using UnitTestGeneration.Easy.App;

internal abstract class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LoanApplication.FindMonthlyPaymentSize(1000, 1500));
    }
}