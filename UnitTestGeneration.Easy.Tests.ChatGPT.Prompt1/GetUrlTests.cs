using UnitTestGeneration.Easy.App;

namespace UnitTestGeneration.Easy.Tests.ChatGPT.Prompt1;

public class GetUrlTests
{
    [Theory]
    [InlineData("https://www.example.com/api/users/", "users")]
    [InlineData("https://www.example.com/api/products/", "products")]
    [InlineData("https://www.example.com/api/orders/", "orders")]
    public void ExtractRequestType_ShouldReturnCorrectRequestType(string urlString, string expected)
    {
        // Arrange
        Uri url = new Uri(urlString);

        // Act
        string result = GetUrl.ExtractRequestType(url);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExtractRequestType_ShouldReturnEmptyString_WhenUrlIsInvalid()
    {
        // Arrange
        Uri invalidUrl = null;

        // Act
        string result = GetUrl.ExtractRequestType(invalidUrl);

        // Assert
        Assert.Equal(string.Empty, result);
    }
}