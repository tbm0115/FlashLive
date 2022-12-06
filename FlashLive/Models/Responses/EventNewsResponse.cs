using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventNewsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventNews[] Data { get; set; }
    }
}
