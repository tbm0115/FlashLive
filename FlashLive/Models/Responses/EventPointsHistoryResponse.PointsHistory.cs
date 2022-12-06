using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventPointsHistoryResponse
    {
        // TODO: Add "CURRENT_GAME"

        public partial class PointsHistory
        {
            [JsonProperty("TAB_NAME")]
            public string TabName { get; set; }

            [JsonProperty("GROUP_LABEL")]
            public string GroupLabel { get; set; }


            [JsonProperty("ITEMS")]
            public Item[] Items { get; set; }
        }
    }
}
