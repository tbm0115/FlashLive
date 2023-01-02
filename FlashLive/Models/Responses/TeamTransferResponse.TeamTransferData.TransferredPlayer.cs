using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamTransferResponse
    {

        public partial class TeamTransferData
        {
            public class TransferredPlayer
            {
                [JsonProperty("PARTICIPANT_ID")]
                public string ParticipantId { get; set; }

                [JsonProperty("PARTICIPANT_IMAGE")]
                public string ParticipantImage { get; set; }

                [JsonProperty("CRNA")]
                public string CRNA { get; set; }

                [JsonProperty("VALUE")]
                public string Value { get; set; }

                [JsonProperty("PURL")]
                public string PURL { get; set; }
            }
        }
    }
}
