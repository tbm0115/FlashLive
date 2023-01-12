﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get starting lineups by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/lineups</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/lineups</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventLineupsResponse> GetEventLineupsAsync(EventLineupsRequestOptions options)
            => await GetAsync<EventLineupsResponse>("events/lineups", options);
    }
}
