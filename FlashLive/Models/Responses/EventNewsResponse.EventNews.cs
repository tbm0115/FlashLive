using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventNewsResponse
    {
        public partial class EventNews
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("TITLE")]
            public string Title { get; set; }

            [JsonProperty("LINK")]
            public string Link { get; set; }

            [JsonProperty("PUBLISHED")]
            public long Published { get; set; }

            [JsonProperty("PROVIDER_NAME")]
            public string ProviderName { get; set; }

            [JsonProperty("CATEGORY_NAME")]
            public string CategoryName { get; set; }

            [JsonProperty("LINKS")]
            public NewsLink[] Links { get; set; }
        }
    }
}
