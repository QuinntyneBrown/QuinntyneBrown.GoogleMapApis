using Microsoft.Extensions.DependencyInjection;

namespace QuinntyneBrown.GoogleMapApis
{
    public static class ServiceCollectionExtensions
    {
        public static void AddGoogleMapApisServices(this IServiceCollection services)
        {
            services.AddSingleton<IGoogleMapsService, GoogleMapsService>();
        }
    }
}
