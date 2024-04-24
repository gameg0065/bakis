using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class LoadApplicationTests
{
    [Fact]
    public void CanGetFamilyLoan_BothAdultsNoKids_ReturnsTrue()
    {
        // Arrange
        byte firstPersonAge = 25;
        byte secondPersonAge = 30;
        bool haveKids = false;
        bool expected = true;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanGetFamilyLoan_BothMinorsNoKids_ReturnsFalse()
    {
        // Arrange
        byte firstPersonAge = 15;
        byte secondPersonAge = 16;
        bool haveKids = false;
        bool expected = false;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanGetFamilyLoan_OneAdultOneMinorNoKids_ReturnsFalse()
    {
        // Arrange
        byte firstPersonAge = 18;
        byte secondPersonAge = 16;
        bool haveKids = false;
        bool expected = false;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanGetFamilyLoan_BothAdultsWithKids_ReturnsTrue()
    {
        // Arrange
        byte firstPersonAge = 20;
        byte secondPersonAge = 25;
        bool haveKids = true;
        bool expected = true;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanGetFamilyLoan_BothMinorsWithKids_ReturnsFalse()
    {
        // Arrange
        byte firstPersonAge = 15;
        byte secondPersonAge = 16;
        bool haveKids = true;
        bool expected = false;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expected, result);
    }
}