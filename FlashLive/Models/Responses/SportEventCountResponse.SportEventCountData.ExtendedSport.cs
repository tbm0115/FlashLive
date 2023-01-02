using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportEventCountResponse
    {

        public partial class SportEventCountData
        {
            public class ExtendedSport
            {
                [JsonProperty("SPORT_ID_FOR_EXTENDED_INFO")]
                public int SportIdForExtendedInfo { get; set; }

                [JsonProperty("SPORT_SORT")]
                public int SportSort { get; set; }
            }
        }
    }
}
