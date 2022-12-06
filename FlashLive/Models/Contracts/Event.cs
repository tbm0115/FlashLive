using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Contracts
{
    /// <summary>
    /// Abstract implementation of the response from <c>/events/list</c>
    /// </summary>
    public abstract class Event
    {
        [JsonProperty("EVENT_ID")]
        public string EventId { get; set; }

        [JsonProperty("START_TIME")]
        public long StartTime { get; set; }

        [JsonProperty("START_UTIME")]
        public long StartTimeUtc { get; set; }

        [JsonProperty("STAGE_TYPE")]
        public EventStageType StageType { get; set; }

        [JsonProperty("MERGE_STAGE_TYPE")]
        public EventStageType MergeStageType { get; set; }

        [JsonProperty("STAGE")]
        public EventStage Stage { get; set; }

        [JsonProperty("SORT")]
        public string Sort { get; set; }

        [JsonProperty("ROUND")]
        public string Round { get; set; }

        [JsonProperty("VISIBLE_RUN_RATE")]
        public int VisibleRunRate { get; set; }

        [JsonProperty("HAS_LINEPS")]
        public int HasLineps { get; set; }

        [JsonProperty("STAGE_START_TIME")]
        public long StageStartTime { get; set; }

        [JsonProperty("GAME_TIME")]
        public string GameTime { get; set; }

        // TODO: Add "PLAYING_ON_SETS"

        // TODO: Add "RECENT_OVERS"

        [JsonProperty("SHORTNAME_AWAY")]
        public string ShortNameAway { get; set; }

        [JsonProperty("AWAY_PARTICIPANT_IDS")]
        public string[] AwayParticipantIds { get; set; }

        [JsonProperty("AWAY_PARTICIPANT_TYPES")]
        public int[] AwayParticipantTypes { get; set; }

        [JsonProperty("AWAY_NAME")]
        public string AwayName { get; set; }

        [JsonProperty("AWAY_PARTICIPANT_NAME_ONE")]
        public string AwayParticipantNameOne { get; set; }

        [JsonProperty("AWAY_EVENT_PARTICIPANT_ID")]
        public string AwayEventParticipantId { get; set; }

        [JsonProperty("WINNER")]
        public int Winner { get; set; }

        [JsonProperty("ODDS_WINNER")]
        public int OddsWinner { get; set; }

        [JsonProperty("ODDS_WINNER_OUTCOME")]
        public int OddsWinnerOutcome { get; set; }

        [JsonProperty("AWAY_GOAL_VAR")]
        public int AwayGoalVar { get; set; }

        [JsonProperty("AWAY_SCORE_CURRENT")]
        public string AwayScoreCurrent { get; set; }

        [JsonProperty("AWAY_IMAGES")]
        public string[] AwayImages { get; set; }

        [JsonProperty("IMM")]
        public string IMM { get; set; }

        [JsonProperty("IMW")]
        public string IMW { get; set; }

        [JsonProperty("IMP")]
        public string IMP { get; set; }

        [JsonProperty("IME")]
        public string IME { get; set; }

        [JsonProperty("SHORTNAME_HOME")]
        public string ShortNameHome { get; set; }

        [JsonProperty("HOME_PARTICIPANT_IDS")]
        public string[] HomeParticipantIds { get; set; }

        [JsonProperty("HOME_PARTICIPANT_TYPES")]
        public int[] HomeParticipantTypes { get; set; }

        [JsonProperty("HOME_NAME")]
        public string HomeName { get; set; }

        [JsonProperty("HOME_PARTICIPANT_NAME_ONE")]
        public string HomeParticipantNameOne { get; set; }

        [JsonProperty("HOME_EVENT_PARTICIPANT_ID")]
        public string HomeEventParticipantId { get; set; }

        [JsonProperty("HOME_GOAL_VAR")]
        public int HomeGoalVar { get; set; }

        [JsonProperty("HOME_SCORE_CURRENT")]
        public string HomeScoreCurrent { get; set; }

        [JsonProperty("HOME_IMAGES")]
        public string[] HomeImages { get; set; }

        [JsonProperty("HAS_LIVE_CENTRE")]
        public int HasLiveCentre { get; set; }
    }
}
