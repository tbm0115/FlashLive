using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get summary of the event by event ID. Incidents of the match.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/summary</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/summary</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        /// <exception cref="NotImplementedException" />
        public async Task GetEventSummaryAsync()
        {
            // events/summary
            throw new NotImplementedException();
        }
    }
}
