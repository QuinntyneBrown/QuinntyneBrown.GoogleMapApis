using Newtonsoft.Json;

namespace QuinntyneBrown.GoogleMapApis
{
    internal static class HttpClientExtensions
    {
        internal static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {            
            HttpResponseMessage httpResponseMessage = await client.GetAsync(url);

            return JsonConvert.DeserializeObject<T>((await httpResponseMessage.Content.ReadAsStringAsync()));
        }
    }
}
