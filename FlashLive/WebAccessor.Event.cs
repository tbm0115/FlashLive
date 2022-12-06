using System;
using System.Threading.Tasks;
using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventResponse.EventData> GetEventAsync(EventRequestOptions options)
        {
            // events/data
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
