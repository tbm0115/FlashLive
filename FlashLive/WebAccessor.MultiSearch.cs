using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Search teams, tournaments and players. Results are shown as you type.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<MultiSearchResponse[]> GetMultiSearchAsync(MultiSearchRequestOptions options)
        {
            // search/multi-search
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/search/multi-search");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<MultiSearchResponse[]>(uriBuilder.ToString());

            return response;
        }
    }
}
