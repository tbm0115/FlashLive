﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get upcoming events by team ID. Use the pagination.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/fixtures</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/fixtures</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamFixturesResponse> GetTeamFixturesAsync(TeamFixturesRequestOptions options)
        {
            // teams/fixtures
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/teams/fixtures");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamFixturesResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
