using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamSquadResponse
    {

        public partial class TeamSquadData
        {
            public class Item
            {
                [JsonProperty("PLAYER_ID")]
                public string PlayerId { get; set; }

                [JsonProperty("PLAYER_NAME")]
                public string PlayerName { get; set; }

                [JsonProperty("PLAYER_TYPE_ID")]
                public string PlayerTypeId { get; set; }

                [JsonProperty("PLAYER_JERSEY_NUMBER")]
                public int PlayerJerseyNumber { get; set; }

                [JsonProperty("PLAYER_FLAG_ID")]
                public int PlayerFlagId { get; set; }

                [JsonProperty("PLAYER_IMAGE_PATH")]
                public string PlayerImagePath { get; set; }
            }
        }
    }
}
