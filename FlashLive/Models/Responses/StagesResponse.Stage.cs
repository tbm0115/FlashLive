using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class StagesResponse
    {
        public class Stage
        {
            [JsonProperty("SPORT_ID")]
            public SportType SportId { get; set; }

            [JsonProperty("COUNTRY_ID")]
            public int CountryId { get; set; }

            [JsonProperty("STAGE_ID")]
            public string StageId { get; set; }

            [JsonProperty("COUNTRY_NAME")]
            public string CountryName { get; set; }

            [JsonProperty("LEAGUE_NAME")]
            public string LeagueName { get; set; }

            [JsonProperty("TOURNAMENT_IMAGE")]
            public string TournamentImage { get; set; }
        }
    }
}
