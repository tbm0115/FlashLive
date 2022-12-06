using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentStageResponse
    {
        public partial class TournamentStageData
        {
            public class Season
            {
                [JsonProperty("SEASON_NAME")]
                public string SeasonName { get; set; }

                [JsonProperty("SEASON_ID")]
                public string SeasonId { get; set; }

                [JsonProperty("SEASON_TOURNAMENT_STAGE_ID")]
                public string SeasonTournamentStageId { get; set; }

                [JsonProperty("SEASON_STANDINGS_TYPE")]
                public int SeasonStandingsType { get; set; }
            }
        }
    }
}
