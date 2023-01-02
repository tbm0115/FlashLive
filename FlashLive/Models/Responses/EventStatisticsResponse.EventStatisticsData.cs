using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventStatisticsResponse
    {
        public partial class EventStatisticsData
        {
            [JsonProperty("STAGE_NAME")]
            public string StageName { get; set; }

            [JsonProperty("GROUPS")]
            public Group[] Groups { get; set; }
        }
    }
}
