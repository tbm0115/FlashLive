using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get the latest player events by player ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>players/last-events</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>players/last-events</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetLatestPlayerEventsAsync()
        {
            // TODO: players/last-events
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/players/last-events");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<LatestPlayerEventsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
