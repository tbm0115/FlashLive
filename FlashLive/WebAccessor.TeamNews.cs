﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of news by team ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>teams/news</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>teams/news</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<TeamNewsResponse> GetTeamNewsAsync(TeamNewsRequestOptions options)
            => await GetAsync<TeamNewsResponse>("teams/news", options);
    }
}
