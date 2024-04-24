using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt3;

public class GetUrlTests
{
    [Fact]
    public void ExtractRequestType_ValidUrl_ReturnsLastSegment()
    {
        // Arrange
        var url = new Uri("https://example.com/api/users");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("users", result);
    }

    [Fact]
    public void ExtractRequestType_UrlWithTrailingSlash_ReturnsLastSegment()
    {
        // Arrange
        var url = new Uri("https://example.com/api/users/");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("users", result);
    }

    [Fact]
    public void ExtractRequestType_UrlWithNoSegments_ReturnsEmptyString()
    {
        // Arrange
        var url = new Uri("https://example.com");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ExtractRequestType_NullUrl_ThrowsArgumentNullException()
    {
        // Arrange
        Uri url = null;

        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => GetUrl.ExtractRequestType(url));
    }
}