using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(20, 20, false)] // Both persons above legal age, no kids
    [InlineData(20, 18, false)] // First person above legal age, second person at legal age, no kids
    [InlineData(18, 20, false)] // First person at legal age, second person above legal age, no kids
    [InlineData(16, 20, false)] // First person below legal age, second person above legal age, no kids
    [InlineData(20, 16, false)] // First person above legal age, second person below legal age, no kids
    [InlineData(16, 16, true)] // Both persons below legal age, with kids
    [InlineData(16, 16, false)] // Both persons below legal age, no kids
    [InlineData(18, 18, true)] // Both persons at legal age, with kids
    public void CanGetFamilyLoan_ShouldReturnTrue_ForEligiblePersons(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(15, 15, false)] // Both persons below legal age, no kids
    [InlineData(15, 17, false)] // First person below legal age, second person at legal age, no kids
    [InlineData(17, 15, false)] // First person at legal age, second person below legal age, no kids
    [InlineData(15, 15, true)] // Both persons below legal age, with kids
    [InlineData(17, 17, false)] // Both persons at legal age, no kids
    public void CanGetFamilyLoan_ShouldReturnFalse_ForIneligiblePersons(byte firstPersonAge, byte secondPersonAge, bool haveKids)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.False(result);
    }
}