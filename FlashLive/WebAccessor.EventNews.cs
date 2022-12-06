using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventNewsResponse.EventNews[]> GetEventNewsAsync(EventNewsRequestOptions options)
        {
            // events/news
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/news");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventNewsResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
