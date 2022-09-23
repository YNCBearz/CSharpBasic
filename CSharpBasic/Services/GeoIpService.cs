using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CSharpBasic.Interfaces;
using CSharpBasic.Models;
using Microsoft.Net.Http.Headers;

namespace CSharpBasic.Services
{
    public class GeoIpService : IGeoIpService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GeoIpService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        private async Task<string> GetIpContents()
        {
            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get,
                "https://api.ipify.org/?format=json")
            {
                Headers =
                {
                    { HeaderNames.Accept, "*/*" },
                }
            };
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            var contents = await httpResponseMessage.Content.ReadAsStringAsync();

            return contents;
        }

        public object GetData()
        {
            var ipContents = GetIpContents();
            var ipInfo =  JsonSerializer.Deserialize<IpInfo>(ipContents.Result);
            return new {ipInfo = ipInfo};
        }
    }
}