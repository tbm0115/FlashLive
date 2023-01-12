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
            => await GetAsync<EventPreviewResponse>("events/preview", options);
    }
}
