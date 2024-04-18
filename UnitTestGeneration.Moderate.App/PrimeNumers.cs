namespace UnitTestGeneration.Moderate.App;
// https://github.com/Mathias007/c-sharp-primary-projects/blob/master/PrimeNumbers/PrimeNumbers/PrimeNumbers.cs
// cy = 15, co = 23
public static class PrimeNumers
{
        public static bool IsNumberEven(int numberToCheck)
        {
            return !Convert.ToBoolean(numberToCheck % 2);
        }
        public static bool IsNumberPrime(int numberToCheck, int potencialDivider = 3)
        {
            bool primeTestResult = Convert.ToBoolean(numberToCheck % potencialDivider);

            if (potencialDivider <= Math.Sqrt(numberToCheck))
            {
                if (!primeTestResult)
                {
                    return primeTestResult;
                }
                else
                {
                    potencialDivider += 2;
                    if (IsNumberPrime(potencialDivider)) 
                    {
                        return IsNumberPrime(numberToCheck, potencialDivider);
                    } 
                    else
                    {
                        potencialDivider += 2;
                        return IsNumberPrime(numberToCheck, potencialDivider);
                    }
                }
            }
            else
            {
                return primeTestResult;
            }
        }

        public static bool PrimeTest(int numberToCheck)
        {
            bool primeTestResult;

            if (numberToCheck > 1)
            {
                if (numberToCheck == 2)
                {
                    primeTestResult = true;
                } else if (IsNumberEven(numberToCheck))
                {
                    primeTestResult = false;
                }
                else if (!IsNumberEven(numberToCheck) && !IsNumberPrime(numberToCheck))
                {
                    primeTestResult = false;
                }
                else if (!IsNumberEven(numberToCheck) && IsNumberPrime(numberToCheck)) 
                {
                    primeTestResult = true;
                } 
                else primeTestResult = false;
            }
            else
            {
                primeTestResult = false;
            }
            return primeTestResult;
        }
}