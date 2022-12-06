using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class TournamentStage
    {
        [JsonProperty("COUNTRY_ID")]
        public int CountryId { get; set; }

        [JsonProperty("COUNTRY_NAME")]
        public string CountryName { get; set; }

        [JsonProperty("LEAGUE_NAME")]
        public string LeagueName { get; set; }

        [JsonProperty("SEASON_ID")]
        public int SeasonId { get; set; }

        [JsonProperty("TEMPLATE_ID")]
        public string TemplateId { get; set; }

        [JsonProperty("PART_SEASON_ID")]
        public string PartSeasonId { get; set; }

        [JsonProperty("STANDINGS_TYPE")]
        public int StandingsType { get; set; }

        [JsonProperty("TOURNAMENT_IMAGE")]
        public string TournamentImage { get; set; }

        [JsonProperty("IMM")]
        public string IMM { get; set; }

        [JsonProperty("IMW")]
        public string IMW { get; set; }

        [JsonProperty("IMP")]
        public string IMP { get; set; }

        [JsonProperty("IME")]
        public string IME { get; set; }

        [JsonProperty("ACTIVE_DRAW_LEVEL")]
        public string ActiveDrawLevel { get; set; }
    }
}
