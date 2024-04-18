using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt3;

public class GetUrlTests
{
    [Fact]
    public void ExtractRequestType_SimpleUrl_ReturnsCorrectRequestType()
    {
        var uri = new Uri("http://example.com/api/users/");
        var result = GetUrl.ExtractRequestType(uri);
        Assert.Equal("users", result);
    }

    [Fact]
    public void ExtractRequestType_UrlWithoutTrailingSlash_ReturnsCorrectRequestType()
    {
        var uri = new Uri("http://example.com/api/products");
        var result = GetUrl.ExtractRequestType(uri);
        Assert.Equal("products", result);
    }

    [Fact]
    public void ExtractRequestType_UrlWithMultipleSegments_ReturnsCorrectRequestType()
    {
        var uri = new Uri("http://example.com/category/electronics/phones/");
        var result = GetUrl.ExtractRequestType(uri);
        Assert.Equal("phones", result);
    }

    [Fact]
    public void ExtractRequestType_RootUrl_ReturnsEmptyString()
    {
        var uri = new Uri("http://example.com/");
        var result = GetUrl.ExtractRequestType(uri);
        Assert.Equal("", result);
    }

    [Fact]
    public void ExtractRequestType_NullUrl_ThrowsArgumentNullException()
    {
        Uri nullUri = null;
        Assert.Throws<ArgumentNullException>(() => GetUrl.ExtractRequestType(nullUri));
    }
}