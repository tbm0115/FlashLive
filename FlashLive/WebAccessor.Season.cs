using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<SeasonResponse.Season[]> GetSeasonAsync(SeasonRequestOptions options)
        {
            // tournaments/seasons/data
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/seasons/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<SeasonResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
