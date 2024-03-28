using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests;


public class UnitTest1
{
    [Fact]
    public void BothAdultsCanGetLoan()
    {
        // Arrange
        const int firstPersonAge = 21;
        const int secondPersonAge = 23;

        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void AdultAndChildCantGetLoan()
    {
        // Arrange
        const int firstPersonAge = 14;
        const int secondPersonAge = 23;
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ChildAndAdultCantGetLoan()
    {
        // Arrange
        const int firstPersonAge = 41;
        const int secondPersonAge = 12;
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void BothKidsCantGetLoan()
    {
        // Arrange
        const int firstPersonAge = 14;
        const int secondPersonAge = 12;
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void MinimumAgeIs18()
    {
        // Arrange
        const int firstPersonAge = 18;
        const int secondPersonAge = 18;
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Bellow18NoLoan()
    {
        // Arrange
        const int firstPersonAge = 17;
        const int secondPersonAge = 17;
        // Act
        var result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge);

        // Assert
        Assert.False(result);
    }
}