using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentListResponse
    {
        public partial class TournamentListData
        {
            [JsonProperty("LEAGUE_NAME")]
            public string LeagueName { get; set; }

            [JsonProperty("COUNTRY_NAME")]
            public string CountryName { get; set; }

            [JsonProperty("COUNTRY_ID")]
            public int CountryId { get; set; }

            [JsonProperty("ACTUAL_TOURNAMENT_SEASON_ID")]
            public string ActualTournamentSeasonId { get; set; }

            [JsonProperty("GROUP_ID")]
            public string GroupId { get; set; }

            /// <remarks>Foreign key to <see cref="SeasonResponse.Season.Value"/></remarks>
            [JsonProperty("SEASON_ID")]
            public int SeasonId { get; set; }

            [JsonProperty("TEMPLATE_ID")]
            public string TemplateId { get; set; }

            [JsonProperty("STAGES")]
            public TournamentStage[] Stages { get; set; }
        }
    }
}
