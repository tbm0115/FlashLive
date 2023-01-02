using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get event statistics by event ID>
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/statistics</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/statistics</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventStatisticsResponse> GetEventStatisticsAsync(EventStatisticsRequestOptions options)
        {
            // events/statistics
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/statistics");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventStatisticsResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
