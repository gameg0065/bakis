using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Gemini;

public class GetUrlTests
{
    [Fact]
    public void TestTypicalUrl()
    {
        Uri url = new Uri("http://example.com/users/profile");
        string expected = "profile";

        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestUrlWithoutTrailingSlash()
    {
        Uri url = new Uri("https://api.example.org/posts/123");
        string expected = "123";

        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestUrlWithEmptyLastSegment()
    {
        Uri url = new Uri("http://example.com/");
        string expected = "";

        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestUrlWithMultipleTrailingSlashes()
    {
        Uri url = new Uri("http://example.com/category//////");
        string expected = "";

        string result = GetUrl.ExtractRequestType(url);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestNullUrl()
    {
        Uri url = null;
        Assert.Throws<ArgumentNullException>(() => GetUrl.ExtractRequestType(url));
    }
}