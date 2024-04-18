using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt3;

public class LoanApplicationTests
{
    // Tests the scenario where the couple has children
        [Fact]
        public void CanGetFamilyLoan_WithKids_CombinedAgeAboveThreshold_ReturnsTrue() 
        {
            // Arrange
            byte firstPersonAge = 20;
            byte secondPersonAge = 25;
            bool haveKids = true;

            // Act
            bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanGetFamilyLoan_WithKids_CombinedAgeBelowThreshold_ReturnsFalse()
        {
            // Arrange
            byte firstPersonAge = 12;
            byte secondPersonAge = 16;
            bool haveKids = true;

            // Act
            bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

            // Assert
            Assert.False(result);
        }

        // Tests the scenario where the couple does _not_ have children
        [Fact]
        public void CanGetFamilyLoan_WithoutKids_BothAboveLegalAge_ReturnsTrue()
        {
            // Arrange
            byte firstPersonAge = 18;
            byte secondPersonAge = 20;
            bool haveKids = false;

            // Act
            bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanGetFamilyLoan_WithoutKids_OneBelowLegalAge_ReturnsFalse()
        {
            // Arrange
            byte firstPersonAge = 17;
            byte secondPersonAge = 22;
            bool haveKids = false;

            // Act
            bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CanGetFamilyLoan_WithoutKids_BothBelowLegalAge_ReturnsFalse()
        {
            // Arrange
            byte firstPersonAge = 16;
            byte secondPersonAge = 16;
            bool haveKids = false;

            // Act
            bool result = LoanApplication.CanGetFamilyLoan(firstPersonAge, secondPersonAge, haveKids);

            // Assert
            Assert.False(result);
        }  
}