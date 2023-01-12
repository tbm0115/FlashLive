using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get player data by player ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>players/data</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>players/data</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetPlayerAsync()
        {
            // TODO: players/data
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/players/data");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<PlayerResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
