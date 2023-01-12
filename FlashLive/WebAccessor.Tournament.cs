using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// get team results by <c>tournamentstageid</c>. Use the pagination.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/results</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/results</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TournamentResponse> GetTournamentAsync(TournamentRequestOptions options)
            => await GetAsync<TournamentResponse>("tournaments/results", options);
    }
}
