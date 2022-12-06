using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventLineupsResponse
    {
        public partial class EventLineup
        {
            [JsonProperty("FORMATION_NAME")]
            public string FormationName { get; set; }

            [JsonProperty("FORMATIONS")]
            public Formation[] Formations { get; set; }

            [JsonProperty("PLAYER_GROUP_TYPE")]
            public int PlayerGroupType { get; set; }
        }
    }
}
