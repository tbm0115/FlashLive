using FlashLive.Models.Contracts;
using FlashLive.Models.RequestOptions;
using FlashLive.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Gets a list of all <see cref="Event"/>s based on the provided <paramref name="options"/>.
        /// </summary>
        /// <typeparam name="T">Reference to the output <see cref="Event"/> type.</typeparam>
        /// <param name="options">Container of query options for the API request.</param>
        /// <returns>Array of implemented <see cref="Event"/>s.</returns>
        public async Task<Stage[]> GetStagesAsync(StageRequestOptions options)
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/tournaments/stages");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<StagesResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
