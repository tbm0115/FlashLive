using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get odds by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/odds</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/odds</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventOddsAsync()
        {
            // TODO: events/odds
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/odds");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventOddsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
