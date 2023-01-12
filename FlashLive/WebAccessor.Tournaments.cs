using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of tournaments by sport ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/list</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/list</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TournamentListResponse> GetTournamentsAsync(TournamentListRequestOptions options)
            => await GetAsync<TournamentListResponse>("tournaments/list", options);
    }
}
