using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class GeometricShapesTests
{
    [Theory]
    [InlineData(0, 0, 0)] // Edge case: both salaries are zero
    [InlineData(1000, 2000, 900)] // Typical scenario
    [InlineData(ushort.MaxValue, ushort.MaxValue, 13106)] // Edge case: maximum values
    [InlineData(ushort.MaxValue, 0, 6553)] // Edge case: one person has maximum salary, the other has zero
    [InlineData(0, ushort.MaxValue, 6553)] // Edge case: one person has zero salary, the other has maximum salary
    public void FindMonthlyPaymentSize_ReturnsCorrectValue(ushort firstPersonSalary, ushort secondPersonSalary, int expected)
    {
        // Arrange

        // Act
        int result = LoanApplication.FindMonthlyPaymentSize(firstPersonSalary, secondPersonSalary);

        // Assert
        Assert.Equal(expected, result);
    }
}