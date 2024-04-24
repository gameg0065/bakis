using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class ChaChaTests
{
// [Fact]
    // public void Load32_ShouldLoadBytesToUint32Correctly()
    // {
    //     // Arrange
    //     byte[] bytes = { 0x01, 0x02, 0x03, 0x04 };
    //     var chaCha = new ChaCha();
    //
    //     // Act
    //     uint result = chaCha.Load32(bytes, 0);
    //
    //     // Assert
    //     Assert.Equal(0x04030201, result);
    // }

    [Fact]
    public void Store32_ShouldStoreUint32ToBytesCorrectly()
    {
        // Arrange
        byte[] bytes = new byte[4];
        var chaCha = new ChaCha();
        uint value = 0x04030201;

        // Act
        chaCha.Store32(bytes, 0, value);

        // Assert
        Assert.Equal(0x01, bytes[0]);
        Assert.Equal(0x02, bytes[1]);
        Assert.Equal(0x03, bytes[2]);
        Assert.Equal(0x04, bytes[3]);
    }

    // [Fact]
    // public void RotateLeft_ShouldRotateBitsCorrectly()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     uint value = 0x01234567;
    //
    //     // Act
    //     uint result = chaCha.RotateLeft(value, 4);
    //
    //     // Assert
    //     Assert.Equal(0x12345670, result);
    // }

    // [Fact]
    // public void Round_ShouldPerformChaChaRoundCorrectly()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     uint a = 0x11111111;
    //     uint b = 0x01020304;
    //     uint c = 0x77073096;
    //     uint d = 0xEE0E337D;
    //
    //     // Act
    //     chaCha.Round(ref a, ref b, ref c, ref d);
    //
    //     // Assert
    //     Assert.Equal(0xEA0C752D, a);
    //     Assert.Equal(0x2511A915, b);
    //     Assert.Equal(0x875FF9A7, c);
    //     Assert.Equal(0x0A02F057, d);
    // }

    // [Fact]
    // public void Init_ShouldInitializeChaChaStateCorrectly()
    // {
    //     // Arrange
    //     var chaCha = new ChaCha();
    //     byte[] key = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
    //                    0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F };
    //     byte[] nonce = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
    //                      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
    //
    //     // Act
    //     uint[] result = chaCha.Init(key, nonce);
    //
    //     // Assert
    //     Assert.Equal(0x61707865, result[0]);
    //     Assert.Equal(0x3320646E, result[1]);
    //     Assert.Equal(0x79622D32, result[2]);
    //     Assert.Equal(0x6B206574, result[3]);
    //     Assert.Equal(0x03020100, result[4]);
    //     Assert.Equal(0x07060504, result[5]);
    //     Assert.Equal(0x0B0A0908, result[6]);
    //     Assert.Equal(0x0F0E0D0C, result[7]);
    //     Assert.Equal(0x13121110, result[8]);
    //     Assert.Equal(0x17161514, result[9]);
    //     Assert.Equal(0x1B1A1918, result[10]);
    //     Assert.Equal(0x1F1E1D1C, result[11]);
    //     Assert.Equal(0x00000000, result[12]);
    //     Assert.Equal(0x00000000, result[13]);
    //     Assert.Equal(0x4A000000, result[14]);
    //     Assert.Equal(0x00000000, result[15]);
    // }
}