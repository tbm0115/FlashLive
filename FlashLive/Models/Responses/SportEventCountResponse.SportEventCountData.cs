using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportEventCountResponse
    {
        public partial class SportEventCountData
        {
            [JsonProperty("SPORTS")]
            public Sport[] Sports { get; set; }

            [JsonProperty("EXTENDED_SPORTS")]
            public ExtendedSport[] ExtendedSports { get; set; }
        }
    }
}
