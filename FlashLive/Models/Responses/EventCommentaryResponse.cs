using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventCommentaryResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventCommentary[] Data { get; set; }

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
