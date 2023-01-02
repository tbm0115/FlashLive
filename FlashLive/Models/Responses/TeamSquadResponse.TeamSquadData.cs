using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamSquadResponse
    {
        public partial class TeamSquadData
        {
            [JsonProperty("GROUP_ID")]
            public int GroupId { get; set; }

            [JsonProperty("GROUP_LABEL")]
            public string GroupLabel { get; set; }

            [JsonProperty("ITEMS")]
            public Item[] Items { get; set; }
        }
    }
}
