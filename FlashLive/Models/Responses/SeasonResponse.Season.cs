using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SeasonResponse
    {
        public class Season
        {
            [JsonProperty("TOURNAMENT_STAGE_ID")]
            public string TournamentStageId { get; set; }

            [JsonProperty("TOURNAMENT_STAGE_STATS_TYPE")]
            public string TournamentStageStatsType { get; set; }

            [JsonProperty("VALUE")]
            public string Value { get; set; }
        }
    }
}
