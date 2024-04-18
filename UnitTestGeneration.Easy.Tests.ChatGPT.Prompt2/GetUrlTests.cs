using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt2;

public class GetUrlTests
{
    [Fact]
    public void ExtractRequestType_ShouldReturnEmptyString_WhenUrlIsNull()
    {
        // Arrange
        Uri url = null;

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnEmptyString_WhenUrlHasNoSegments()
    {
        // Arrange
        Uri url = new Uri("https://example.com");

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnLastSegment_WhenUrlHasSegments()
    {
        // Arrange
        Uri url = new Uri("https://example.com/api/data");

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("data", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnTrimmedLastSegment_WhenLastSegmentHasTrailingSlash()
    {
        // Arrange
        Uri url = new Uri("https://example.com/api/data/");

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("data", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldHandleMultipleSegments()
    {
        // Arrange
        Uri url = new Uri("https://example.com/api/data/user/profile");

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("profile", result);
    }
}