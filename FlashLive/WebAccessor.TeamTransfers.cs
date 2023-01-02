﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get team transfers by team ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/transfers</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/transfers</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamTransferResponse> GetTeamTransfersAsync(TeamTransferRequestOptions options)
        {
            // teams/transfers
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/teams/transfers");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamTransferResponse>(uriBuilder.ToString());

            return response;
        }
    }
}
