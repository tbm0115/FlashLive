using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of popular tournaments by sport ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/popular</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/popular</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TournamentPopularResponse> GetTournamentPopularAsync(TournamentPopularRequestOptions options)
        {
            // tournaments/popular
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/popular");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TournamentPopularResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
