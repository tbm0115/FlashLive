using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get squad by team ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/squad</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/squad</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamSquadResponse> GetTeamSquadAsync(TeamSquadRequestOptions options)
        {
            // teams/squad
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/teams/squad");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamSquadResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
