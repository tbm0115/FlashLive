using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventBriefResponse
    {
        public class EventBrief
        {
            [JsonProperty("EVENT_STAGE_TYPE_ID")]
            public int EventStageTypeId { get; set; }

            [JsonProperty("EVENT_MERGE_STAGE_TYPE_ID")]
            public int EventMergeStageTypeId { get; set; }

            [JsonProperty("EVENT_STAGE_ID")]
            public int EventStageId { get; set; }

            [JsonProperty("EVENT_STAGE_START_TIME")]
            public long EventStageStartTime { get; set; }

            // TODO: Add "HasLiveCentre"

            [JsonProperty("EVENT_START_TIME")]
            public long EventStartTime { get; set; }

            [JsonProperty("END_TIME")]
            public long EndTime { get; set; }

            [JsonProperty("HOME_SCORE")]
            public string HomeScore { get; set; }

            [JsonProperty("AWAY_SCORE")]
            public string AwayScore { get; set; }

            [JsonProperty("HOME_FULL_TIME_SCORE")]
            public string HomeFullTimeScore { get; set; }

            [JsonProperty("AWAY_FULL_TIME_SCORE")]
            public string AwayFullTimeScore { get; set; }

            [JsonProperty("GAME_TIME")]
            public long GameTime { get; set; }

            [JsonProperty("BETTING_TYPE_MAIN")]
            public int BettingTypeMain { get; set; }

            // TODO: Add "EVENT_INFO"

            [JsonProperty("FEATURES")]
            public string Features { get; set; }

            [JsonProperty("DEI")]
            public string DEI { get; set; }

            [JsonProperty("SPORT_ID")]
            public SportType SportId { get; set; }

            // TODO: Add "FINAL_RESULT_ONLY"

            [JsonProperty("EI")]
            public string EI { get; set; }

            [JsonProperty("FEATURES_ACTIVE")]
            public string FeaturesActive { get; set; }

            [JsonProperty("TOURNAMENT_STAGE_ID")]
            public string TournamentStageId { get; set; }

            [JsonProperty("PARTICIPANT_HOME")]
            public string ParticipantHome { get; set; }

            [JsonProperty("PARTICIPANT_AWAY")]
            public string ParticipantAway { get; set; }

            [JsonProperty("TOURNAMENT_NAME")]
            public string TournamentName { get; set; }

            [JsonProperty("TOURNAMENT_SHORT_NAME")]
            public string TournamentShortName { get; set; }

            [JsonProperty("COUNTRY_ID")]
            public int CountryId { get; set; }

            [JsonProperty("TOURNAMENT_LINK")]
            public string TournamentLink { get; set; }

            [JsonProperty("WINNER")]
            public string Winner { get; set; }

            [JsonProperty("WINNER_FT")]
            public int WinnerFT { get; set; }

            [JsonProperty("BETTING_WINNER")]
            public int BettingWinner { get; set; }

            [JsonProperty("BETTING_BOOKMAKER_ID")]
            public int BettingBookmakerId { get; set; }

            [JsonProperty("BETTING_TYPE")]
            public int BettingType { get; set; }

            [JsonProperty("BETTING_BOOKMAKER_NAME")]
            public int BettingBookmakerName { get; set; }
        }
    }
}
