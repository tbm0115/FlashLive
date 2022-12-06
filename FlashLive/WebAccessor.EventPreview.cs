using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventPreviewResponse.EventPreview[]> GetEventPreviewAsync(EventPreviewRequestOptions options)
        {
            // events/preview
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/preview");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventPreviewResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
