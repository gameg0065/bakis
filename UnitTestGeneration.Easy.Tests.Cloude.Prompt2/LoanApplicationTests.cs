using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(18, 19, false)] // Both persons are above legal age, no kids
    [InlineData(20, 25, false)] // Both persons are above legal age, no kids
    public void CanGetFamilyLoan_NoKids_BothAboveLegalAge_ReturnsTrue(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(16, 19, false)] // First person is below legal age, no kids
    [InlineData(18, 15, false)] // Second person is below legal age, no kids
    [InlineData(15, 16, false)] // Both persons are below legal age, no kids
    public void CanGetFamilyLoan_NoKids_OneOrBothBelowLegalAge_ReturnsFalse(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(18, 18, true)] // Both persons are of legal age, have kids
    [InlineData(20, 25, true)] // Both persons are above legal age, have kids
    public void CanGetFamilyLoan_HaveKids_BothAboveLegalAge_ReturnsTrue(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(16, 19, true)] // First person is below legal age, have kids
    [InlineData(18, 15, true)] // Second person is below legal age, have kids
    [InlineData(15, 16, true)] // Both persons are below legal age, have kids
    public void CanGetFamilyLoan_HaveKids_OneOrBothBelowLegalAge_ReturnsFalse(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanGetFamilyLoan_HaveKids_CombinedAgeEqualsFiftyOne_ReturnsTrue()
    {
        // Arrange
        byte firstPersonAge = 17;
        byte secondPersonAge = 34;
        bool haveKids = true;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanGetFamilyLoan_HaveKids_CombinedAgeFifty_ReturnsFalse()
    {
        // Arrange
        byte firstPersonAge = 25;
        byte secondPersonAge = 25;
        bool haveKids = true;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }
}