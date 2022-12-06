using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventLineupsResponse.EventLineup[]> GetEventLineupsAsync(EventLineupsRequestOptions options)
        {
            // events/lineups
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/lineups");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventLineupsResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
