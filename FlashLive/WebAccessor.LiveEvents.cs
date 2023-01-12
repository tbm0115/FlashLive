using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get list of live events. Use <c>/live-update</c> to get changes in live events!
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/live-list</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/live-list</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetLiveEventsAsync()
        {
            // TODO: events/live-list
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/live-list");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<LiveEventsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
