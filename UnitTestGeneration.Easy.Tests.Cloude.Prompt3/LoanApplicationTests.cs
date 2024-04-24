using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(18, 18, true)]
    [InlineData(18, 17, true)]
    [InlineData(17, 18, true)]
    [InlineData(20, 20, true)]
    public void CanGetFamilyLoan_WithKids_ReturnsTrue(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(16, 16, true)]
    [InlineData(15, 17, true)]
    [InlineData(17, 15, true)]
    public void CanGetFamilyLoan_WithKids_ReturnsFalse(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(18, 18, false)]
    [InlineData(20, 18, false)]
    [InlineData(18, 20, false)]
    public void CanGetFamilyLoan_WithoutKids_ReturnsTrue(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(17, 18, false)]
    [InlineData(18, 17, false)]
    [InlineData(17, 17, false)]
    [InlineData(16, 18, false)]
    [InlineData(18, 16, false)]
    public void CanGetFamilyLoan_WithoutKids_ReturnsFalse(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanGetFamilyLoan_WithMaxByte_ReturnsTrue()
    {
        // Arrange
        byte firstPersonAge = byte.MaxValue;
        byte secondPersonAge = byte.MaxValue;
        bool haveKids = true;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanGetFamilyLoan_WithMinByte_ReturnsFalse()
    {
        // Arrange
        byte firstPersonAge = byte.MinValue;
        byte secondPersonAge = byte.MinValue;
        bool haveKids = false;

        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }
}