using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get player statistics by event ID, (basketball)
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/player-statistics-alt</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/player-statistics-alt</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventStatisticsResponse> GetEventStatisticsAsync_Basketball(EventStatisticsRequestOptions options)
            => await GetAsync<EventStatisticsResponse>("events/player-statistics-alt", options);
    }
}
