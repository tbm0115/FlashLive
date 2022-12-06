using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class EventResponse<T> : IResponse where T : Event
    {
        [JsonProperty("DATA")]
        public EventCategory<T>[] Data { get; set; }

        // TODO: Add "META"

        public string LastChangeKey { get; set; }
    }
}
