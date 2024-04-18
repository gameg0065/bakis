using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class PrimeNumbersTests
{
        [Fact]
        public void IsNumberEven_ShouldReturnTrueForEvenNumbers()
        {
            Assert.True(PrimeNumbers.IsNumberEven(2));
            Assert.True(PrimeNumbers.IsNumberEven(4));
            Assert.True(PrimeNumbers.IsNumberEven(10));
        }

        [Fact]
        public void IsNumberEven_ShouldReturnFalseForOddNumbers()
        {
            Assert.False(PrimeNumbers.IsNumberEven(1));
            Assert.False(PrimeNumbers.IsNumberEven(3));
            Assert.False(PrimeNumbers.IsNumberEven(9));
        }

        [Fact]
        public void IsNumberPrime_ShouldIdentifySmallPrimesCorrectly()
        {
            Assert.True(PrimeNumbers.IsNumberPrime(2));
            Assert.True(PrimeNumbers.IsNumberPrime(3));
            Assert.True(PrimeNumbers.IsNumberPrime(5));
            Assert.True(PrimeNumbers.IsNumberPrime(7));
            Assert.True(PrimeNumbers.IsNumberPrime(11));
        }

        [Fact]
        public void IsNumberPrime_ShouldIdentifyNonPrimesCorrectly()
        {
            Assert.False(PrimeNumbers.IsNumberPrime(1));
            Assert.False(PrimeNumbers.IsNumberPrime(4));
            Assert.False(PrimeNumbers.IsNumberPrime(6));
            Assert.False(PrimeNumbers.IsNumberPrime(8));
            Assert.False(PrimeNumbers.IsNumberPrime(9));
        }

        [Fact]
        public void PrimeTest_ShouldIdentifyPrimesCorrectly()
        {
            Assert.True(PrimeNumbers.PrimeTest(2));
            Assert.True(PrimeNumbers.PrimeTest(3));
            Assert.True(PrimeNumbers.PrimeTest(5));
            Assert.True(PrimeNumbers.PrimeTest(7));
            Assert.True(PrimeNumbers.PrimeTest(11));
        }

        [Fact]
        public void PrimeTest_ShouldIdentifyNonPrimesCorrectly()
        {
            Assert.False(PrimeNumbers.PrimeTest(1));
            Assert.False(PrimeNumbers.PrimeTest(4));
            Assert.False(PrimeNumbers.PrimeTest(6));
            Assert.False(PrimeNumbers.PrimeTest(8));
            Assert.False(PrimeNumbers.PrimeTest(9));
        }

        [Fact]
        public void PrimeTest_ShouldHandleInvalidInput()
        {
            Assert.False(PrimeNumbers.PrimeTest(0));
            Assert.False(PrimeNumbers.PrimeTest(-1));
        }
}