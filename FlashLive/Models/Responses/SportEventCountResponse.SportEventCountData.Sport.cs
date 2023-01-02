using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportEventCountResponse
    {

        public partial class SportEventCountData
        {
            public class Sport
            {
                [JsonProperty("SPORT_ID")]
                public SportType SportId { get; set; }

                [JsonProperty("EVENTS_COUNT")]
                public int EventsCount { get; set; }

                [JsonProperty("EVENTS_COUNT_LIVE")]
                public int EventsCountLive { get; set; }

                [JsonProperty("IS_POPULAR")]
                public bool IsPopular { get; set; }

                [JsonProperty("SPORT_NAME")]
                public string SportName { get; set; }
            }
        }
    }
}
