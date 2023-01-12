using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get team results by team ID. Use the pagination.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/results</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/results</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamResultsResponse> GetTeamResultsAsync(TeamResultsRequestOptions options)
            => await GetAsync<TeamResultsResponse>("teams/results", options);
    }
}
