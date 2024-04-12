using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini.Prompt1;

public class GetUrlTests
{
    [Fact]
    public void SimpleUrl_ReturnsRequestType()
    {
        Uri url = new Uri("http://example.com/users");
        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal("users", result);
    }

    [Fact]
    public void MultiSegmentUrl_ReturnsRequestType()
    {
        Uri url = new Uri("http://example.com/api/v1/products");
        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal("products", result);
    }

    [Fact]
    public void TrailingSlash_ReturnsRequestType()
    {
        Uri url = new Uri("http://example.com/search/");
        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal("search", result);
    }

    [Fact]
    public void EmptySegment_ReturnsEmptyString()
    {
        Uri url = new Uri("http://example.com/");
        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal("", result);
    }

    [Fact]
    public void NullUrl_ThrowsException()
    {
        Uri url = null;
        Assert.Throws<ArgumentNullException>(() => GetUrl.ExtractRequestType(url));
    }
}