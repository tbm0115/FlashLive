using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get team data by team ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamResponse> GetTeamAsync(TeamRequestOptions options)
            => await GetAsync<TeamResponse>("teams/data", options);
    }
}
