internal abstract class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LoanApplication.CanGetFamilyLoan(28, 19));
        Console.WriteLine(LoanApplication.CanGetFamilyLoan(12, 19));
    }
}

public static class LoanApplication
{
    public static bool CanGetFamilyLoan(uint firstPersonAge, uint secondPersonAge)
    {
        const int legalAge = 17;
        return firstPersonAge > legalAge && secondPersonAge > legalAge;
        
        // Or
    }
}