using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get events between two teams by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/h2h</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/h2h</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventH2HAsync()
        {
            // TODO: events/h2h
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/h2h");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventH2HResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
