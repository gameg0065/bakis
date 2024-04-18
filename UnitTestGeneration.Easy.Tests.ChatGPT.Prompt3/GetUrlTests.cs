using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt3;

public class GetUrlTests
{
    [Fact]
    public void ExtractRequestType_ShouldReturnLastSegment_WhenUrlHasSingleSegment()
    {
        // Arrange
        var url = new Uri("https://example.com/test");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("test", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnLastSegment_WhenUrlHasMultipleSegments()
    {
        // Arrange
        var url = new Uri("https://example.com/test/segment/");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("segment", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnLastSegment_WhenUrlHasTrailingSlash()
    {
        // Arrange
        var url = new Uri("https://example.com/test/");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("test", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnLastSegment_WhenUrlHasSpecialCharacters()
    {
        // Arrange
        var url = new Uri("https://example.com/test!/segment%2F");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("segment%2F", result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnEmptyString_WhenUrlHasNoSegments()
    {
        // Arrange
        var url = new Uri("https://example.com");

        // Act
        var result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal("", result);
    }
}