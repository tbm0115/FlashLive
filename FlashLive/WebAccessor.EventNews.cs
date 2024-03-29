﻿using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get news by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/news</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/news</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventNewsResponse> GetEventNewsAsync(EventNewsRequestOptions options)
            => await GetAsync<EventNewsResponse>("events/news", options);
    }
}
