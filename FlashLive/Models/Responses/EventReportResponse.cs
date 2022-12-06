using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventReportResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventReport[] Data { get; set; }

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
