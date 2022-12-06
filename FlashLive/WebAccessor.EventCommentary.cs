using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventCommentaryResponse.EventCommentary[]> GetEventCommentaryAsync(EventCommentaryRequestOptions options)
        {
            // events/commentary
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/commentary");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventCommentaryResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
