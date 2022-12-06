using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventLineupsResponse
    {
        public partial class EventLineup
        {
            public partial class Formation
            {
                public class Member
                {
                    [JsonProperty("ROW_ID")]
                    public int RowId { get; set; }

                    [JsonProperty("PLAYER_ID")]
                    public string PlayerId { get; set; }

                    [JsonProperty("PLAYER_FULL_NAME")]
                    public string PlayerFullName { get; set; }

                    [JsonProperty("SHORT_NAME")]
                    public string ShortName { get; set; }

                    [JsonProperty("PLAYER_NUMBER")]
                    public int PlayerNumber { get; set; }

                    [JsonProperty("PLAYER_COUNTRY")]
                    public int PlayerCountry { get; set; }

                    [JsonProperty("PLAYER_POSITION_ID")]
                    public int PlayerPositionId { get; set; }

                    [JsonProperty("PLAYER_TYPE")]
                    public int PlayerType { get; set; }
                }
            }
        }
    }
}
