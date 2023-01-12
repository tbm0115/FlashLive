using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get data about the sport and the number of sport events.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>sports/events-count</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>sports/events-count</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<SportEventCountResponse> GetSportEventsAsync(SportEventCountRequestOptions options)
            => await GetAsync<SportEventCountResponse>("sports/events-count", options);
    }
}
