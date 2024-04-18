using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class LoadApplicationTests
{
    [Fact]
    public void FindMonthlyPaymentSize_ZeroSalaries_ReturnsZero()
    {
        ushort salary1 = 0;
        ushort salary2 = 0;

        int result = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);
        Assert.Equal(0, result);
    }

    [Fact]
    public void FindMonthlyPaymentSize_TypicalSalaries_CalculatesCorrectly()
    {
        ushort salary1 = 2000;
        ushort salary2 = 1500;

        int result = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);
        Assert.Equal(1050, result); // 3500 / 10 * 3 = 1050 
    }

    [Fact]
    public void FindMonthlyPaymentSize_MaxUshortValues_HandlesOverflow()
    {
        ushort salary1 = ushort.MaxValue;
        ushort salary2 = ushort.MaxValue;

        // You have a few options on how to handle this:

        // Option 1: Expect an OverflowException
        Assert.Throws<OverflowException>(() => LoanApplication.FindMonthlyPaymentSize(salary1, salary2));

        // Option 2: Change the return type of the method (e.g., to 'long') to accommodate the calculation

        // Option 3: Decide on a maximum monthly payment and clamp or throw an exception if it's exceeded
    }
}