using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorCowin.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static async Task<T> Deserialize<T>(this HttpResponseMessage response)
        {
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<T>(responseAsString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.None,
            });
            return responseObject;
        }
    }
}
