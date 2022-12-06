using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventResponse
    {
        public class EventData
        {
            [JsonProperty("EVENT")]
            public Event Event { get; set; }

            [JsonProperty("TOURNAMENT")]
            public EventDataTournament Tournament { get; set; }

            [JsonProperty("SPORT")]
            public EventDataSport Sport { get; set; }

            public class EventDataTournament
            {
                [JsonProperty("NAME")]
                public string Name { get; set; }

                [JsonProperty("HEADER")]
                public string Header { get; set; }

                [JsonProperty("NAME_PART_1")]
                public string NamePart1 { get; set; }

                [JsonProperty("NAME_PART_2")]
                public string NamePart2 { get; set; }

                [JsonProperty("TOURNAMENT_STAGE_ID")]
                public string TournamentStageId { get; set; }

                [JsonProperty("TOURNAMENT_TYPE")]
                public string TournamentType { get; set; }

                [JsonProperty("TOURNAMENT_ID")]
                public string TournamentId { get; set; }

                [JsonProperty("SOURCE_TYPE")]
                public int SourceType { get; set; }

                [JsonProperty("HAS_LIVE_TABLE")]
                public int HasLiveTable { get; set; }

                [JsonProperty("STANDING_INFO")]
                public int StandingInfo { get; set; }

                [JsonProperty("TEMPLATE_ID")]
                public string TemplateId { get; set; }

                [JsonProperty("TOURNAMENT_STAGE_TYPE")]
                public int TournamentStageType { get; set; }

                [JsonProperty("SHORT_NAME")]
                public string ShortName { get; set; }

                [JsonProperty("URL")]
                public string Url { get; set; }

                [JsonProperty("TOURNAMENT_IMAGE")]
                public string TournamentImage { get; set; }

                [JsonProperty("SORT")]
                public string Sort { get; set; }

                [JsonProperty("SUPER_TEMPLATE_ID")]
                public int SuperTemplateId { get; set; }

                [JsonProperty("STAGES_COUNT")]
                public int StagesCount { get; set; }

                // TODO: Add "ZKL"

                // TODO: Add "ZKU"

                [JsonProperty("TOURNAMENT_SEASON_ID")]
                public string TournamentSeasonId { get; set; }

                [JsonProperty("CATEGORY_NAME")]
                public string CategoryName { get; set; }
            }

            public class EventDataSport
            {
                [JsonProperty("SPORT_ID")]
                public int SportId { get; set; }
            }
        }
    }
}
