using System;
using System.Threading.Tasks;
using FlashLive.Models.Responses;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of sports.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>sports/list</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>sports/list</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<SportsResponse> GetSportsAsync()
            => await GetAsync<SportsResponse>("sports/list");
    }
}
