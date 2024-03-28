namespace UnitTestGeneration.Difficult.App;

public static class LoanApplication
{
    static bool CanGetFamilyLoan(int firstPersonAge, int secondPersonAge)
    {
        const int legalAge = 17;
        return firstPersonAge > legalAge && secondPersonAge > legalAge;
    }
    
    static int FindMonthlyPaymentSize(int firstPersonSalary, int secondPersonSalary)
    {
        var sum = (firstPersonSalary + secondPersonSalary) / 10 * 3;
        return sum;
    }

    public static Tuple<bool, int> IsFamilyApplicableForLoad(Tuple<int,int> ages, Tuple<int, int> salaries)
    {
        const int minimumPaymentSize = 100;
        if (CanGetFamilyLoan(ages.Item1, ages.Item2))
        {
            var monthlyPaymentSize = FindMonthlyPaymentSize(salaries.Item1, salaries.Item2);
            if (monthlyPaymentSize > minimumPaymentSize)
            {
                return new Tuple<bool, int>(true, monthlyPaymentSize);
            }

            return new Tuple<bool, int>(false, monthlyPaymentSize);
        }

        return new Tuple<bool, int>(false, 0);
    }
}


// kodo charakteristikas

// SonarCube ir t.t.
// Ciklomatini, coupling (3 testas) ir kohesion. - 4.
// Koda generuoja irankis 1 = 1 ?