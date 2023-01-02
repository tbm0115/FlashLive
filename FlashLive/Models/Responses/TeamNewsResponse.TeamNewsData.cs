using Newtonsoft.Json;
using System;

namespace FlashLive.Models.Responses
{
    public partial class TeamNewsResponse
    {
        public class TeamNewsData
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("TITLE")]
            public string Title { get; set; }

            [JsonProperty("LINK")]
            public string Link { get; set; }

            [JsonProperty("PUBLISHED")]
            public long Published { get; set; }

            [JsonIgnore]
            public DateTime PublishedDate => Convert.ToDateTime(Published);

            [JsonProperty("PROVIDER_NAME")]
            public string ProviderName { get; set; }

            [JsonProperty("NEWS_FEED_TYPE_ID")]
            public int NewsFeedTypeId { get; set; }
        }
    }
}
