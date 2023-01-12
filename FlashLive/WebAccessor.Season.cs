using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get season data by <c>season_id</c>.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>seasons/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>seasons/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<SeasonResponse> GetSeasonAsync(SeasonRequestOptions options)
            => await GetAsync<SeasonResponse>("tournaments/seasons/data", options);
    }
}
