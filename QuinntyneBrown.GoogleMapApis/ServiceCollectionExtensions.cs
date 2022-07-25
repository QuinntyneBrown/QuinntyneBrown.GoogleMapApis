using Microsoft.Extensions.DependencyInjection;

namespace QuinntyneBrown.GoogleMapApis
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGoogleMapApisServices(this IServiceCollection services, Action<GoogleMapApisOptions> options)
        {
            services.Configure(options);
            services.AddSingleton<IGoogleMapsService, GoogleMapsService>();
            return services;
        }
    }
}
