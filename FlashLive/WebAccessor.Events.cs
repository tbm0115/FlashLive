using FlashLive.Models;
using FlashLive.Models.Contracts;
using FlashLive.Models.RequestOptions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<T[]> GetEventsAsync<T>(EventRequestOptions<T> options) where T : Event
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/list");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventResponse<T>>(uriBuilder.ToString());

            return response.Data.SelectMany(o => o.Events).ToArray();
        }
    }
}
