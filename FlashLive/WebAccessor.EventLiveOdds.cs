using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get live odds by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/live-odds</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/live-odds</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventLiveOddsAsync()
        {
            // TODO: events/live-odds
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/live-odds");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventLiveOddsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
