using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get an event preview by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/preview</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/preview</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventPreviewResponse> GetEventPreviewAsync(EventPreviewRequestOptions options)
        {
            // events/preview
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/preview");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventPreviewResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
