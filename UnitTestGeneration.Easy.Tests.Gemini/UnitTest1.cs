using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class UnitTest1
{
    [Fact]
    public void FindMonthlyPaymentSize_TypicalInput_CalculatesCorrectly()
    {
        // Arrange
        ushort salary1 = 2000;
        ushort salary2 = 1500;
        int expectedPayment = 1050;

        // Act
        int actualPayment = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);

        // Assert
        Assert.Equal(expectedPayment, actualPayment);
    }

    [Fact]
    public void FindMonthlyPaymentSize_ZeroSalary_ReturnsZero()
    {
        // Arrange
        ushort salary1 = 0;
        ushort salary2 = 0;
        int expectedPayment = 0;

        // Act
        int actualPayment = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);

        // Assert
        Assert.Equal(expectedPayment, actualPayment);
    }

    [Fact]
    public void FindMonthlyPaymentSize_LargeSalaries_HandlesOverflow()
    {
        // Arrange
        ushort salary1 = ushort.MaxValue; 
        ushort salary2 = ushort.MaxValue;

        // Act & Assert           
        Assert.Throws<OverflowException>(() => LoanApplication.FindMonthlyPaymentSize(salary1, salary2));
    } 

    // An additional test using XUnit's Theory for multiple inputs
    [Theory]
    [InlineData(3000, 1000, 1200)] 
    [InlineData(500, 800, 390)] 
    [InlineData(0, 500, 150)]
    public void FindMonthlyPaymentSize_VariedInputs_CalculatesCorrectly(ushort salary1, ushort salary2, int expectedPayment)
    {
        // Act
        int actualPayment = LoanApplication.FindMonthlyPaymentSize(salary1, salary2);

        // Assert
        Assert.Equal(expectedPayment, actualPayment);
    }
}