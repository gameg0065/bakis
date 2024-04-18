namespace UnitTestGeneration.Moderate.App;

public static class LoanApplication
{
    public static bool CanGetFamilyLoan(byte firstPersonAge, byte secondPersonAge, bool haveKids = false)
    {
        const int legalAge = 17;
        if (haveKids)
        {
            return (firstPersonAge + secondPersonAge) > legalAge * 3;
        }
        return firstPersonAge > legalAge && secondPersonAge > legalAge;
    }
}