using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a ball by ball on an event (cricket) by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/ball-by-ball</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/ball-by-ball</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventBallByBallAsync_Cricket()
        {
            // TODO: events/ball-by-ball
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/ball-by-ball");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventBallByBallResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
