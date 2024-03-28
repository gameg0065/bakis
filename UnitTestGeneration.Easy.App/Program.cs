// See https://aka.ms/new-console-template for more information

internal abstract class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LoanApplication.FindMonthlyPaymentSize(1000, 1500));
        Console.WriteLine(LoanApplication.FindMonthlyPaymentSize(-100, 12));
    }
}

public static class LoanApplication
{
    // Sveikas teigiamas skaicius
    public static uint FindMonthlyPaymentSize(uint firstPersonSalary, uint secondPersonSalary)
    {
        var sum = (firstPersonSalary + secondPersonSalary) / 10 * 3;
        return sum;
    }
}