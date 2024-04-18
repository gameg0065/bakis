using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt1;

public class PrimeNumersTests
{
        [Fact]
        public void IsNumberEven_ShouldReturnTrueForEvenNumbers()
        {
            Assert.True(PrimeNumers.IsNumberEven(2));
            Assert.True(PrimeNumers.IsNumberEven(4));
            Assert.True(PrimeNumers.IsNumberEven(10));
        }

        [Fact]
        public void IsNumberEven_ShouldReturnFalseForOddNumbers()
        {
            Assert.False(PrimeNumers.IsNumberEven(1));
            Assert.False(PrimeNumers.IsNumberEven(3));
            Assert.False(PrimeNumers.IsNumberEven(9));
        }

        [Fact]
        public void IsNumberPrime_ShouldIdentifySmallPrimesCorrectly()
        {
            Assert.True(PrimeNumers.IsNumberPrime(2));
            Assert.True(PrimeNumers.IsNumberPrime(3));
            Assert.True(PrimeNumers.IsNumberPrime(5));
            Assert.True(PrimeNumers.IsNumberPrime(7));
            Assert.True(PrimeNumers.IsNumberPrime(11));
        }

        [Fact]
        public void IsNumberPrime_ShouldIdentifyNonPrimesCorrectly()
        {
            Assert.False(PrimeNumers.IsNumberPrime(1));
            Assert.False(PrimeNumers.IsNumberPrime(4));
            Assert.False(PrimeNumers.IsNumberPrime(6));
            Assert.False(PrimeNumers.IsNumberPrime(8));
            Assert.False(PrimeNumers.IsNumberPrime(9));
        }

        [Fact]
        public void PrimeTest_ShouldIdentifyPrimesCorrectly()
        {
            Assert.True(PrimeNumers.PrimeTest(2));
            Assert.True(PrimeNumers.PrimeTest(3));
            Assert.True(PrimeNumers.PrimeTest(5));
            Assert.True(PrimeNumers.PrimeTest(7));
            Assert.True(PrimeNumers.PrimeTest(11));
        }

        [Fact]
        public void PrimeTest_ShouldIdentifyNonPrimesCorrectly()
        {
            Assert.False(PrimeNumers.PrimeTest(1));
            Assert.False(PrimeNumers.PrimeTest(4));
            Assert.False(PrimeNumers.PrimeTest(6));
            Assert.False(PrimeNumers.PrimeTest(8));
            Assert.False(PrimeNumers.PrimeTest(9));
        }

        [Fact]
        public void PrimeTest_ShouldHandleInvalidInput()
        {
            Assert.False(PrimeNumers.PrimeTest(0));
            Assert.False(PrimeNumers.PrimeTest(-1));
        }
}