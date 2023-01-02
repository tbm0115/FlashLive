using System;
using System.Threading.Tasks;
using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get all event data by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventResponse> GetEventAsync(EventRequestOptions options)
        {
            // events/data
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
