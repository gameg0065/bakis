using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.Cloude.Prompt2;

public class GetUrlTests
{
    [Theory]
    [InlineData("https://example.com/api/products", "products")]
    [InlineData("https://example.com/api/customers/123", "123")]
    [InlineData("https://example.com/api/orders/", "orders")]
    public void ExtractRequestType_ValidUrl_ReturnsLastSegment(string urlString, string expected)
    {
        // Arrange
        Uri url = new Uri(urlString);

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

    [Theory]
    [InlineData("https://example.com")]
    [InlineData("https://example.com/")]
    public void ExtractRequestType_UrlWithoutSegments_ReturnsEmptyString(string urlString)
    {
        // Arrange
        Uri url = new Uri(urlString);

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(string.Empty, result);
    }
}