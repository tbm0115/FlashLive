using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventStatisticsResponse
    {

        public partial class EventStatisticsData
        {
            public partial class Group
            {
                [JsonProperty("GROUP_LABEL")]
                public string GroupLabel { get; set; }

                [JsonProperty("ITEMS")]
                public Item[] Items { get; set; }
            }
        }
    }
}
