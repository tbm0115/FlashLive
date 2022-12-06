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
        /// Gets <see cref="TournamentStageData"/>s based on the provided <paramref name="options"/>.
        /// </summary>
        /// <param name="options">Container of query options for the API request.</param>
        /// <returns>Array of implemented <see cref="TournamentStageData"/>s.</returns>
        public async Task<TournamentStageResponse.TournamentStageData> GetTournamentStagesAsync(TournamentStageRequestOptions options)
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/stages/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TournamentStageResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
