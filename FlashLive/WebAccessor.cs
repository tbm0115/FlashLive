using FlashLive.Models.Contracts;
using FlashLive.Models.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlashLive
{
    /// <summary>
    /// Accesses the FlashLive API on RapidAPI
    /// </summary>
    /// <see href="https://rapidapi.com/tipsters/api/flashlive-sports"/>
    public partial class WebAccessor : IDisposable
    {
        internal const string API_ROOT_URI = "https://flashlive-sports.p.rapidapi.com";
        internal const string API_VERSION = "v1";

        private HttpClient _httpClient;
        private HttpClient Client
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                    _httpClient.DefaultRequestHeaders.Accept.Clear();
                    _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    _httpClient.DefaultRequestHeaders.Add("User-Agent", "Off the Wall Creations");
                    _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apiKey);
                    _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "flashlive-sports.p.rapidapi.com");
                }
                return _httpClient;
            }
        }

        private string _apiKey;

        public WebAccessor(string apiKey)
        {
            _apiKey = apiKey;
        }

        public virtual async Task<T> GetAsync<T>(string uri)
        {
            var json = await Client.GetStringAsync(uri);

            if (string.IsNullOrEmpty(json)) throw new NullReferenceException();

            var jsonOptions = new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                },
                TypeNameHandling = TypeNameHandling.Auto
            };
            var result = JsonConvert.DeserializeObject<T>(json, jsonOptions);
            if (result == null) throw new NullReferenceException();
            return result;
        }

        public async Task<T> GetAsync<T>(string endpoint, IRequestOptions? options = null) where T : IResponse
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/{endpoint}");

            if (options != null)
                options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<T>(uriBuilder.ToString());

            return response;
        }

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}
