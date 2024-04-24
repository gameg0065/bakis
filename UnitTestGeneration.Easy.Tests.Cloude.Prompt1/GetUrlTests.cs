using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt1;

public class GetUrlTests
{
    [Fact]
    public void ExtractRequestType_SingleSegment_ReturnsSegment()
    {
        // Arrange
        Uri url = new Uri("https://example.com/users");
        string expected = "users";

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtractRequestType_MultipleSegments_ReturnsLastSegment()
    {
        // Arrange
        Uri url = new Uri("https://example.com/api/v1/users/123");
        string expected = "123";

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtractRequestType_TrailingSlash_RemovesTrailingSlash()
    {
        // Arrange
        Uri url = new Uri("https://example.com/users/");
        string expected = "users";

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtractRequestType_NoSegments_ReturnsEmptyString()
    {
        // Arrange
        Uri url = new Uri("https://example.com");
        string expected = "";

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtractRequestType_NullUrl_ThrowsArgumentNullException()
    {
        // Arrange
        Uri url = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => GetUrl.ExtractRequestType(url));
    }
}