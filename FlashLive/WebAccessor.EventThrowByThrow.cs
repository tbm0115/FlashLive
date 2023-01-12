using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get throw by throw (darts) by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/throw-by-throw</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/throw-by-throw</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetEventThrowByThrowAsync()
        {
            // TODO: events/throw-by-throw
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/throw-by-throw");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<EventThrowByThrowResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
