using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventPreviewResponse
    {
        public class EventPreview
        {
            [JsonProperty("CONTENT")]
            public string Content { get; set; }
        }
    }
}
