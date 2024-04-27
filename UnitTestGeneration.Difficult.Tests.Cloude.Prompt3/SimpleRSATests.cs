using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class SimpleRSATests
{
[Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(11)]
    public void IsPrime_ValidPrimes_ReturnsTrue(long p)
    {
        Assert.True(SimpleRSA.IsPrime(p));
    }

    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    public void IsPrime_NonPrimes_ReturnsFalse(long p)
    {
        Assert.False(SimpleRSA.IsPrime(p));
    }

    [Theory]
    [InlineData(2, 3)]
    [InlineData(3, 5)]
    [InlineData(5, 7)]
    [InlineData(7, 11)]
    public void CheckPrimes_ValidPrimes_ReturnsTrue(long p, long q)
    {
        Assert.True(SimpleRSA.CheckPrimes(p, q));
    }

    [Theory]
    [InlineData(2, 2)]
    [InlineData(4, 6)]
    [InlineData(8, 9)]
    public void CheckPrimes_InvalidPrimes_ReturnsFalse(long p, long q)
    {
        Assert.False(SimpleRSA.CheckPrimes(p, q));
    }

    [Fact]
    public void GetPrimes_ValidInput_ReturnsCorrectPrimes()
    {
        long[] expectedPrimes = { 3, 40, 5, 12, 17, 28, 19, 180 };
        long p = 23, q = 29;
        long[] primes = SimpleRSA.GetPrimes(p, q);
        Assert.Equal(expectedPrimes, primes);
    }

    [Fact]
    public void GetEncryptExp_ValidInput_ReturnsCorrectExponent()
    {
        long p = 23, q = 29;
        long expectedEncryptExp = 3;
        long encryptExp = SimpleRSA.GetEncryptExp(p, q);
        Assert.Equal(expectedEncryptExp, encryptExp);
    }

    [Fact]
    public void GetDecryptExp_ValidInput_ReturnsCorrectExponent()
    {
        long x = 3, t = 528;
        long expectedDecryptExp = 175;
        long decryptExp = SimpleRSA.GetDecryptExp(x, t);
        Assert.Equal(expectedDecryptExp, decryptExp);
    }

    [Fact]
    public void Encrypt_ValidInput_ReturnsCorrectEncryptedText()
    {
        long key = 3, modulus = 667;
        string msg = "Hello";
        long[] expectedEncrypted = { 108, 108, 120, 120, 111 };
        long[] encrypted = SimpleRSA.Encrypt(key, modulus, msg);
        Assert.Equal(expectedEncrypted, encrypted);
    }

    [Fact]
    public void Decrypt_ValidInput_ReturnsCorrectDecryptedText()
    {
        long key = 175, modulus = 667;
        long[] encrypted = { 108, 108, 120, 120, 111 };
        string expectedDecrypted = "Hello";
        string decrypted = SimpleRSA.Decrypt(key, modulus, encrypted);
        Assert.Equal(expectedDecrypted, decrypted);
    }

    [Theory]
    [InlineData(5, 7, 13, 45)]
    [InlineData(3, 5, 23, 8)]
    [InlineData(2, 3, 5, 1)]
    public void MulMod_ValidInput_ReturnsCorrectResult(long a, long b, long mod, long expected)
    {
        long result = SimpleRSA.MulMod(a, b, mod);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 7, 13, 45)]
    [InlineData(3, 5, 23, 8)]
    [InlineData(2, 3, 5, 1)]
    public void MulModTwo_ValidInput_ReturnsCorrectResult(long a, long b, long mod, long expected)
    {
        long result = SimpleRSA.MulModTwo(a, b, mod);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-3, 5, 2)]
    [InlineData(10, 7, 3)]
    public void PosMod_IntValidInput_ReturnsCorrectResult(int a, int n, int expected)
    {
        int result = SimpleRSA.PosMod(a, n);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-3, 5, 2)]
    [InlineData(10, 7, 3)]
    public void PosMod_LongValidInput_ReturnsCorrectResult(long a, long n, long expected)
    {
        long result = SimpleRSA.PosMod(a, n);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EncryptTwo_ValidInput_ReturnsCorrectEncryptedText()
    {
        long key = 3, modulus = 667;
        string msg = "Hello";
        long[] expectedEncrypted = { 108, 108, 120, 120, 111 };
        long[] encrypted = SimpleRSA.EncryptTwo(key, modulus, msg);
        Assert.Equal(expectedEncrypted, encrypted);
    }

    [Fact]
    public void DecryptTwo_ValidInput_ReturnsCorrectDecryptedText()
    {
        long key = 175, modulus = 667;
        long[] encrypted = { 108, 108, 120, 120, 111 };
        string expectedDecrypted = "Hello";
        string decrypted = SimpleRSA.DecryptTwo(key, modulus, encrypted);
        Assert.Equal(expectedDecrypted, decrypted);
    }

    [Theory]
    [InlineData(2, 3, 5, 4)]
    [InlineData(3, 5, 23, 10)]
    [InlineData(5, 7, 13, 8)]
    public void ModularPow_IntValidInput_ReturnsCorrectResult(int num, int exponent, int modulus, int expected)
    {
        int result = SimpleRSA.ModularPow(num, exponent, modulus);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 5, 4)]
    [InlineData(3, 5, 23, 10)]
    [InlineData(5, 7, 13, 8)]
    public void ModularPow_LongValidInput_ReturnsCorrectResult(long num, long exponent, long modulus, long expected)
    {
        long result = SimpleRSA.ModularPow(num, exponent, modulus);
        Assert.Equal(expected, result);
    }

}