using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamFixturesResponse
    {

        public partial class TeamFixture
        {
            public class Event
            {
                [JsonProperty("EVENT_ID")]
                public string EventId { get; set; }

                [JsonProperty("START_TIME")]
                public long StartTime { get; set; }

                [JsonProperty("START_UTIME")]
                public long StartUTime { get; set; }

                [JsonProperty("STAGE_TYPE")]
                public string StageType { get; set; }

                [JsonProperty("MERGE_STAGE_TYPE")]
                public string MergeStageType { get; set; }

                [JsonProperty("STAGE")]
                public string Stage { get; set; }

                [JsonProperty("SORT")]
                public string Sort { get; set; }

                [JsonProperty("ROUND")]
                public string Round { get; set; }

                [JsonProperty("ERN")]
                public string ERN { get; set; }

                [JsonProperty("GN")]
                public string GN { get; set; }

                [JsonProperty("VISIBLE_RUN_RATE")]
                public int VisibleRunRate { get; set; }

                [JsonProperty("HAS_LINEPS")]
                public int HasLineps { get; set; }

                [JsonProperty("AUDIO_COMMENT_URL")]
                public string AudioCommentUrl { get; set; }

                [JsonProperty("GAME_TIME")]
                public string GameTime { get; set; }

                [JsonProperty("WL")]
                public string WL { get; set; }

                [JsonProperty("HAS_SWAPPED_PARTICIPANTS")]
                public string HasSwappedParticipants { get; set; }

                [JsonProperty("MATCH_COMMENTS")]
                public string MatchComments { get; set; }

                [JsonProperty("WQ")]
                public string WQ { get; set; }

                [JsonProperty("SHORTNAME_HOME")]
                public string ShortnameHome { get; set; }

                [JsonProperty("HOME_PARTICIPANT_IDS")]
                public string[] HomeParticipantIds { get; set; }

                [JsonProperty("HOME_PARTICIPANT_TYPES")]
                public int[] HomeParticipantTypes { get; set; }

                [JsonProperty("NJ")]
                public string NJ { get; set; }

                [JsonProperty("NJL")]
                public string NJL { get; set; }

                [JsonProperty("HOME_NAME")]
                public string HomeName { get; set; }

                [JsonProperty("HOME_PARTICIPANT_NAME_ONE")]
                public string HomeParticipantNameOne { get; set; }

                [JsonProperty("HOME_EVENT_PARTICIPANT_ID")]
                public string HomeEventParticipantId { get; set; }

                [JsonProperty("HOME_SLUG")]
                public string HomeSlug { get; set; }

                [JsonProperty("HOME_GOAL_VAR")]
                public int HomeGoalVar { get; set; }

                [JsonProperty("HOME_IMAGES")]
                public string[] HomeImages { get; set; }

                [JsonProperty("IMM")]
                public string IMM { get; set; }

                [JsonProperty("IMW")]
                public string IMW { get; set; }

                [JsonProperty("IMP")]
                public string IMP { get; set; }

                [JsonProperty("IME")]
                public string IME { get; set; }

                [JsonProperty("SHORTNAME_AWAY")]
                public string ShortnameAway { get; set; }

                [JsonProperty("AWAY_PARTICIPANT_IDS")]
                public string[] AwayParticipantIds { get; set; }

                [JsonProperty("AWAY_PARTICIPANT_TYPES")]
                public int[] AwayParticipantTypes { get; set; }

                [JsonProperty("AWAY_NAME")]
                public string AwayName { get; set; }

                [JsonProperty("AWAY_PARTICIPANT_NAME_ONE")]
                public string AwayParticipantNameOne { get; set; }

                [JsonProperty("AWAY_PARTICIPANT_ID")]
                public string AwayEventParticipantId { get; set; }

                [JsonProperty("AWAY_SLUG")]
                public string AwaySlug { get; set; }

                [JsonProperty("AWAY_GOAL_VAR")]
                public int AwayGoalVar { get; set; }

                [JsonProperty("AWAY_IMAGES")]
                public string[] AwayImages { get; set; }

                [JsonProperty("AL")]
                public string AL { get; set; }

                [JsonProperty("HAS_LIVE_CENTRE")]
                public int HasLiveCentre { get; set; }

                [JsonProperty("SHOW_IN_MY_TEAMS")]
                public int ShowInMyTeams { get; set; }
            }
        }
    }
}
