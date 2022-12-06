using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventLineupsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventLineup[] Data { get; set; }

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
