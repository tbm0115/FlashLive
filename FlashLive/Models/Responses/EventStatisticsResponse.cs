using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventStatisticsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventStatisticsData[] Data { get; set; }

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
