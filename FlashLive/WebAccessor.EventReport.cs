using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get an event report by event ID.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/report</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/report</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<EventReportResponse> GetEventReportAsync(EventReportRequestOptions options)
            => await GetAsync<EventReportResponse>("events/report", options);
    }
}
