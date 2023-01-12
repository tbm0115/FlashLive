using FlashLive.Models.RequestOptions;
using System;
using System.Threading.Tasks;
using FlashLive.Models.Responses;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of stages by sport ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>tournaments/stages</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>tournaments/stages</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<StagesResponse> GetStagesAsync(StagesRequestOptions options)
            => await GetAsync<StagesResponse>("tournaments/stages", options);
    }
}
