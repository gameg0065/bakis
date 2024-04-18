using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(5000, 3000, 2400)]  // Basic Calculation
    [InlineData(20000, 15000, 10500)] // Large Salaries
    [InlineData(0, 10000, 3000)]    // Zero Salary
    [InlineData(ushort.MaxValue, ushort.MaxValue, 19500)] // Max ushort value
    public void FindMonthlyPaymentSize_CalculatesCorrectly(ushort salary1, ushort salary2, int expected)
    {
        int result = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);
        Assert.Equal(expected, result);
    }
}