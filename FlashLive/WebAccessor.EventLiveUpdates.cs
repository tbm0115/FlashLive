using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get only new data into live-events by <c>sport_id</c>. Call every 5 seconds.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/live-update</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/live-update</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventLiveUpdatesResponse> GetEventLiveUpdatesAsync(EventLiveUpdatesRequestOptions options)
            => await GetAsync<EventLiveUpdatesResponse>("events/live-update", options);
    }
}
