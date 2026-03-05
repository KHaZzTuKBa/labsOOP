using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Laba3.Tests;

public class HomePageTests : IClassFixture<CustomWebApplicationFactory>
{
	private readonly CustomWebApplicationFactory _factory;

	public HomePageTests(CustomWebApplicationFactory factory)
	{
		_factory = factory;
	}

	[Fact]
	public async Task Get_HomeIndex_ReturnsSuccessStatusCode()
	{
		// Arrange
		var client = _factory.CreateClient();

		// Act
		var response = await client.GetAsync("/");

		// Assert
		Assert.Equal(HttpStatusCode.OK, response.StatusCode);
	}
}

