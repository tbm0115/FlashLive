using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get highlights video by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/highlights</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/highlights</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventHighlightsAsync()
        {
            // TODO: events/highlights
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/highlights");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventHighlightsResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
