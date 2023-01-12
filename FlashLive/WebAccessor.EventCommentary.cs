using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a comment on an event by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/commentary</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/commentary</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventCommentaryResponse> GetEventCommentaryAsync(EventCommentaryRequestOptions options)
            => await GetAsync<EventCommentaryResponse>("events/commentary", options);
    }
}
