﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get team results by team ID. Use the pagination.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/results</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/results</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamResultsResponse> GetTeamResultsAsync(TeamResultsRequestOptions options)
        {
            // teams/results
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/teams/results");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamResultsResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
