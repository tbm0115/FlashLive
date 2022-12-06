using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventLineupsResponse
    {
        public partial class EventLineup
        {
            public partial class Formation
            {
                [JsonProperty("FORMATION_LINE")]
                public int FormationLine { get; set; }

                [JsonProperty("MEMBERS")]
                public Member[] Members { get; set; }
            }
        }
    }
}
