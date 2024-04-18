using UnitTestGeneration.Moderate.App;

namespace UnitTestGeneration.Moderate.Tests.Gemini.Prompt2;

public class PrimeNumbersTests
{
    [Fact]
    public void IsNumberEven_Zero_ReturnsTrue()
    {
        var result = PrimeNumbers.IsNumberEven(0);
        Assert.True(result);
    }
    [Fact]
    public void IsNumberEven_EvenNumber_ReturnsTrue()
    {
        var result = PrimeNumbers.IsNumberEven(8);
        Assert.True(result);
    }
    [Fact]
    public void IsNumberEven_OddNumber_ReturnsFalse()
    {
        var result = PrimeNumbers.IsNumberEven(7);
        Assert.False(result);
    }
    
    [Fact]
    public void IsNumberPrime_NumberLessThanTwo_ReturnsFalse() 
    {
        var result = PrimeNumbers.IsNumberPrime(0);
        Assert.False(result);
    }
    
    [Fact]
    public void IsNumberPrime_PrimeNumber_ReturnsTrue()
    {
        var result = PrimeNumbers.IsNumberPrime(11);
        Assert.True(result);
    }
    [Fact]
    public void IsNumberPrime_NonPrimeNumber_ReturnsFalse()
    {
        var result = PrimeNumbers.IsNumberPrime(15);
        Assert.False(result);
    }

    [Fact]
    public void PrimeTest_ZeroAndOne_ReturnsFalse()
    {
        Assert.False(PrimeNumbers.PrimeTest(0)); 
        Assert.False(PrimeNumbers.PrimeTest(1)); 
    }
    [Fact]
    public void PrimeTest_Two_ReturnsTrue()
    {
        var result = PrimeNumbers.PrimeTest(2);
        Assert.True(result);
    }
    [Fact]
    public void PrimeTest_EvenNumber_ReturnsFalse()
    {
        var result = PrimeNumbers.PrimeTest(12);
        Assert.False(result);
    }

    

}