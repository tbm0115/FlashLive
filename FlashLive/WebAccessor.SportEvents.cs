using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get data about the sport and the number of sport events.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>sports/events-count</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>sports/events-count</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<SportEventCountResponse> GetSportEventsAsync(SportEventCountRequestOptions options)
        {
            // sports/events-count
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/sports/events-count");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<SportEventCountResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
