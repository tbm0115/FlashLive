using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get upcoming events by <c>tournamentstageid</c>. Use the pagination.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/fixtures</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/fixtures</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TournamentFixturesResponse> GetTournamentFixturesAsync(TournamentFixturesRequestOptions options)
        {
            // tournaments/fixtures
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/fixtures");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TournamentFixturesResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
