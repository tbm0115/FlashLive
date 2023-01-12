using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get brief data by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/brief</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/brief</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventBriefResponse> GetEventBriefAsync(EventBriefRequestOptions options)
            => await GetAsync<EventBriefResponse>("events/brief", options);
    }
}
