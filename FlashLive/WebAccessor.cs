using FlashLive.Models.Contracts;
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

        /// <summary>
        /// Constructs a new instance of a helper class capable of sending requests to the FlashLive API.
        /// </summary>
        /// <param name="apiKey">Reference to the RapidAPI key for the FlashLive API.</param>
        public WebAccessor(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Gets a <typeparamref name="T"/> from the provided <paramref name="uri"/>.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="IResponse"/> to be deserialized and returned from the response.</typeparam>
        /// <param name="uri">Full API url to send the web request.</param>
        /// <returns>Deserialized response from the API as <typeparamref name="T"/>.</returns>
        /// <exception cref="NullReferenceException">Thrown either when the web response is empty or the object could not be deserialized.</exception>
        public virtual async Task<T> GetAsync<T>(string uri) where T : IResponse
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

        /// <summary>
        /// Get a <typeparamref name="T"/> from the provided <paramref name="endpoint"/> in the FlashLive API.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="IResponse"/> to be deserialized and returned from the response.</typeparam>
        /// <param name="endpoint">API endpoint to be appended to the FlashLive URL.</param>
        /// <param name="options">Optional reference of <see cref="IRequestOptions"/> to concatenate in the URL parameters.</param>
        /// <returns>Deserialized response from the API as <typeparamref name="T"/>.</returns>
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
