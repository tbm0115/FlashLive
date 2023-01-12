using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a fall of wickets on an event (cricket) by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/fall-of-wickets</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/fall-of-wickets</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventFallOfWicketsAsync_Cricket()
        {
            // TODO: events/fall-of-wickets
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/fall-of-wickets");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventFallOfWicketsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
