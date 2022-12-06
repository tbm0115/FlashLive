using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventData Data { get; set; }

        [JsonProperty("META")]
        public EventMeta Meta { get; set; }

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
