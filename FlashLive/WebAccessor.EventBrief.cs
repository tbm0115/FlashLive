using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventBriefResponse.EventBrief> GetEventBriefAsync(EventBriefRequestOptions options)
        {
            // events/brief
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/brief");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventBriefResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
