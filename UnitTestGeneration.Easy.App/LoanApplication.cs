namespace UnitTestGeneration.Easy.App;

public static class LoanApplication
{
    public static int FindMonthlyPaymentSize(ushort firstPersonSalary, ushort secondPersonSalary)
    {
        var sum = (firstPersonSalary + secondPersonSalary) / 10 * 3;
        return sum;
    }
}