namespace UnitTestGeneration.Moderate.App;
// https://github.com/Mathias007/c-sharp-primary-projects/blob/master/PrimeNumbers/PrimeNumbers/PrimeNumbers.cs
// cy = 15, co = 23
public class PrimeNumers
{
        private static bool IsNumberEven(int numberToCheck)
        {
            return !Convert.ToBoolean(numberToCheck % 2);
        }
        private static bool IsNumberPrime(int numberToCheck, int potencialDivider = 3)
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
            string primeTestMessage = "";

            if (numberToCheck > 1)
            {
                if (numberToCheck == 2)
                {
                    primeTestMessage="Wpisana liczba jest pierwsza, ponieważ wynosi 2!";
                    primeTestResult = true;
                } else if (IsNumberEven(numberToCheck))
                {
                    primeTestMessage = "Podana liczba nie jest pierwsza, ponieważ jest parzysta!";
                    primeTestResult = false;
                }
                else if (!IsNumberEven(numberToCheck) && !IsNumberPrime(numberToCheck))
                {
                    primeTestMessage = "Chociaż wpisana liczba jest nieparzysta, to jednak nie jest pierwsza, ponieważ jest złożona!";
                    primeTestResult = false;
                }
                else if (!IsNumberEven(numberToCheck) && IsNumberPrime(numberToCheck)) 
                {
                    primeTestMessage = "Wpisana liczba jest pierwsza, ponieważ przeszła pozytywnie test pierwszości!";
                    primeTestResult = true;
                } 
                else primeTestResult = false;
            }
            else
            {
                primeTestMessage = "Wpisz poprawną liczbę!";
                primeTestResult = false;
            }

            Console.WriteLine(primeTestMessage);
            return primeTestResult;
        }

        public static void HandleProgram()
        {
            Console.WriteLine("Wpisz liczbę naturalną większą od 1 do przeprowadzenia na niej testu pierwszości");
            int numberToCheck = int.Parse(Console.ReadLine());
            PrimeTest(numberToCheck);

            Console.WriteLine("Test pierwszości został wykonany. Czy chcesz sprawdzić kolejną liczbę? (Y - Tak, inny klawisz - zakończenie programu)");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.Clear();
                HandleProgram();
            }
            else
            {
                Console.WriteLine("Dziękujemy za skorzystanie z programu");
                Console.ReadKey();
            }
        }
}