using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventsResponse<T> : IResponse where T : Event
    {
        [JsonProperty("DATA")]
        public EventsData<T>[] Data { get; set; }

        // TODO: Add "META"

        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
