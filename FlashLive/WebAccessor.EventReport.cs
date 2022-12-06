using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventReportResponse.EventReport[]> GetEventReportAsync(EventReportRequestOptions options)
        {
            // events/report
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/report");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventReportResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
