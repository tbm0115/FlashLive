using FlashLive.Models;
using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get tournament data by <c>tournamentstageid</c>.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/stages/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/stages/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TournamentStageResponse> GetTournamentStagesAsync(TournamentStageRequestOptions options)
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/stages/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TournamentStageResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
