using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Refit;
using UIFaces;

namespace StatDNS.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        public const string BaseApiUrl = "http://uifaces.com/api";
        public readonly IUIFaceApi Client;

        public IntegrationTests()
        {
            Client = RestService.For<IUIFaceApi>(BaseApiUrl);
        }


        [Test]
        public async void GetUsernameShouldBeExpected()
        {
            var response = await Client.GetUsername("geoffreyhuntley");
            response.Username.Should().Be("geoffreyhuntley");
            response.ImageUrls.Mini.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Normal.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Bigger.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Epic.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
        }


        [Test]
        public async void GetRandomShouldBeExpected()
        {
            var response = await Client.Random();
            response.Username.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Mini.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Normal.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Bigger.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
            response.ImageUrls.Epic.AbsoluteUri.Should().NotBeNullOrWhiteSpace();
        }
    }
}