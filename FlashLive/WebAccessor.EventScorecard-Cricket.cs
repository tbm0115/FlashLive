using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a scorecard on an event (cricket) by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/scorecard</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/scorecard</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventScorecardAsync_Cricket()
        {
            // TODO: events/scorecard
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/scorecard");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventScorecardResponse_Cricket>(uriBuilder.ToString());

            //return response;
        }
    }
}
