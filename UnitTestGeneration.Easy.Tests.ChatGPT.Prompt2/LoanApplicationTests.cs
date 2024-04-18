using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class LoadApplicationTests
{
    [Theory]
    [InlineData(18, 18, false, true)] // Both persons are eligible without kids
    [InlineData(18, 17, false, false)] // One person is ineligible without kids
    [InlineData(17, 17, false, false)] // Both persons are ineligible without kids
    [InlineData(18, 18, true, true)] // Both persons are eligible with kids
    [InlineData(18, 17, true, false)] // One person is ineligible with kids
    [InlineData(17, 17, true, false)] // Both persons are ineligible with kids
    public void CanGetFamilyLoan_ShouldReturnCorrectResult(byte firstPersonAge, byte secondPersonAge, bool haveKids, bool expectedResult)
    {
        // Act
        bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}