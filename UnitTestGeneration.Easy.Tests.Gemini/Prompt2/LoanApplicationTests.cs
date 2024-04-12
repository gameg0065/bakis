using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt2;

public class LoadApplicationTests
{
    [Fact]
    public void TestTypicalSalaries()
    {
        ushort firstPersonSalary = 2500;
        ushort secondPersonSalary = 3000;
        int expectedPayment = 1650;

        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);
        Assert.Equal(expectedPayment, result);
    }

    [Fact]
    public void TestZeroSalary()
    {
        ushort firstPersonSalary = 0;
        ushort secondPersonSalary = 0;
        int expectedPayment = 0;

        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);
        Assert.Equal(expectedPayment, result);
    }

    [Fact]
    public void TestMaximumSalary() 
    {
        ushort firstPersonSalary = ushort.MaxValue;
        ushort secondPersonSalary = ushort.MaxValue;

        // Potential overflow - Might want to reconsider calculation logic
        Assert.Throws<OverflowException>(() => LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary)); 
    }
}