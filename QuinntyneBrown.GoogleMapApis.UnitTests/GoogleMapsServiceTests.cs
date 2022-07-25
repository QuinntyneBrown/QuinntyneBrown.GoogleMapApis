using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace QuinntyneBrown.GoogleMapApis.UnitTests;

public class GoogleMapsServiceTests
{
    [Fact]
    public void ShouldGetRequiredServuce_NoErrors()
    {
        var container = new ServiceCollection()
            .AddHttpClient()
            .AddGoogleMapApisServices(o => {
                o.ApiKey = "Key";
            })
            .BuildServiceProvider();

        var googleMapsService = container.GetRequiredService<IGoogleMapsService>();

        Assert.NotNull(googleMapsService);
    }
}