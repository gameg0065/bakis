// See https://aka.ms/new-console-template for more information

using UnitTestGeneration.Easy.App;

internal abstract class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(LoanApplication.FindMonthlyPaymentSize(1000, 1500));
        
        // // CheckForPalindrome
        // Console.WriteLine(CheckForPalindrome.IsPalindrome(101));
        // Console.WriteLine(CheckForPalindrome.IsPalindrome(123));
        //
        // // DoubleZeroArray
        // Console.WriteLine(DoubleZeroArray.DuplicateZeros([1, 0])[2]);
        //
        // // Evaluations
        // Console.WriteLine(Evaluations.Evaluate("2/10"));
        
        //FindConsecutive
        // Console.WriteLine(FindConsecutive.FindMaxConsecutiveOnes([1, 0, 1, 1, 0 , 1 , 1]));
        
        // FindNumberWithEvenDigitsNum
        // Console.WriteLine(FindNumberWithEvenDigitsNum.FindNumbers([10, 23, 1 ,2, 1122, 1232]));
        
        
        // GeometricShapes
        Console.WriteLine(GeometricShapes.RectangleShape.Area(2));
        Console.WriteLine(GeometricShapes.TriangleShape.Area(2));
        Console.WriteLine(GeometricShapes.SquareShape.Area(2));
        Console.WriteLine(GeometricShapes.CircleShape.Area(2));
        
        
        
    }
}