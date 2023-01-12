using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get all missing players by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/missing-players</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/missing-players</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventMissingPlayersAsync()
        {
            // TODO: events/missing-players
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/missing-players");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventMissingPlayersResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
