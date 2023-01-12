using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get the player events by player ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>players/alt-events</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>players/alt-events</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetPlayerEventsAsync()
        {
            // TODO: players/alt-events
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/players/alt-events");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<PlayerEventsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
