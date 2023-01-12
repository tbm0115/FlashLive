using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get new data keys. Call this point to see what data has been changed.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/last-change</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/last-change</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventLastChangesResponse> GetEventLastChangesAsync(EventLastChangesRequestOptions options)
            => await GetAsync<EventLastChangesResponse>("events/last-change", options);
    }
}
