using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamTransferResponse
    {

        public partial class TeamTransferData
        {
            public class Team
            {
                [JsonProperty("TEAM_TYPE")]
                public int TeamType { get; set; }

                [JsonProperty("PARTICIPANT_IMAGE")]
                public string ParticipantImage { get; set; }

                [JsonProperty("VALUE")]
                public string Value { get; set; }

                [JsonProperty("TURL")]
                public string TUrl { get; set; }
            }
        }
    }
}
