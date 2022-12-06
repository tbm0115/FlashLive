using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class StagesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Stage[] Data { get; set; }

        public string LastChangeKey { get; set; }
    }
    public class EventsResponse<T> : IResponse where T : Event
    {
        [JsonProperty("DATA")]
        public EventData<T>[] Data { get; set; }

        // TODO: Add "META"

        public string LastChangeKey { get; set; }
    }
}
