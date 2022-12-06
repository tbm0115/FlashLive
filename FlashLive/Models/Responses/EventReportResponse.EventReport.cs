using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventReportResponse
    {
        public partial class EventReport
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("TITLE")]
            public string Title { get; set; }

            [JsonProperty("CONTENT")]
            public string Content { get; set; }

            [JsonProperty("AUTHOR")]
            public string Author { get; set; }

            [JsonProperty("PUBLISHED")]
            public long Published { get; set; }

            [JsonProperty("PROVIDER_NAME")]
            public string ProviderName { get; set; }

            [JsonProperty("IMAGES")]
            public Image[] Images { get; set; }
        }
    }
}
