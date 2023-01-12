using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get the history of points by event ID. Point by Point.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/points-history</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/points-history</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventPointsHistoryResponse> GetEventPointsHistoryAsync(EventPointsHistoryRequestOptions options)
            => await GetAsync<EventPointsHistoryResponse>("events/points-history", options);
    }
}
