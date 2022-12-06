using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventBriefResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventBrief Data { get; set; }
    }
}
