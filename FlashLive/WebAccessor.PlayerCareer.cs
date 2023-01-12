using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get player career by player ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>players/career</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>players/career</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        [Obsolete("Not Implemented Yet")]
        public async Task GetPlayerCareerAsync()
        {
            // TODO: players/career
            throw new NotImplementedException();
            //var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/players/career");
            //options.AddUrlParameters(ref uriBuilder);

            //var response = await GetAsync<PlayerCareerResponse>(uriBuilder.ToString());

            //return response;
        }
    }
}
