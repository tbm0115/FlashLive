using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventPreviewResponse : IResponse
    {
        [JsonProperty("DATA")]
        public EventPreview[] Data { get; set; }
    }
}
