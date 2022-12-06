using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<EventPointsHistoryResponse.PointsHistory[]> GetEventPointsHistoryAsync(EventPointsHistoryRequestOptions options)
        {
            // events/points-history
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/points-history");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventPointsHistoryResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
