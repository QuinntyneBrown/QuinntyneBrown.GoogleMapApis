using Microsoft.Extensions.Options;

namespace QuinntyneBrown.GoogleMapApis
{
    internal class GoogleMapsService : IGoogleMapsService
    {
        private readonly HttpClient _client;
        private readonly GoogleMapApisOptions _options;
        public GoogleMapsService(HttpClient client, IOptions<GoogleMapApisOptions> optionsAccessor)
        {
            _client = client;
            _options = optionsAccessor.Value;
        }

        public async Task<GoogleEncodeResponse> GetAddress(double latitude, double longitude)
        {
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?latlng={latitude},{longitude}&sensor=false&key={_options.ApiKey}";
            
            return await _client.GetAsync<GoogleEncodeResponse>(url);
        }

        public async Task<GoogleEncodeResponse> GetCoordinates(string address)
        {
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={address}&sensor=false&key={_options.ApiKey}";
            
            return await _client.GetAsync<GoogleEncodeResponse>(url);
        }
    }
}
