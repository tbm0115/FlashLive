using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamResponse
    {
        public class Team
        {
            [JsonProperty("ID")]
            public string Id { get; set; }

            [JsonProperty("LAYOUT")]
            public string Layout { get; set; }

            [JsonProperty("SHORT_NAME")]
            public string ShortName { get; set; }

            [JsonProperty("GENDER_ID")]
            public int GenderId { get; set; }

            [JsonProperty("COUNTRY_ID")]
            public int CountryId { get; set; }

            [JsonProperty("COUNTRY_NAME")]
            public string CountryName { get; set; }

            [JsonProperty("IMAGE_PATH")]
            public string ImagePath { get; set; }

            [JsonProperty("IMM")]
            public string IMM { get; set; }

            [JsonProperty("IMW")]
            public string IMW { get; set; }

            [JsonProperty("IMP")]
            public string IMP { get; set; }

            [JsonProperty("IME")]
            public string IME { get; set; }

            [JsonProperty("IMAGE_TABLE_PATH")]
            public string ImageTablePath { get; set; }

            [JsonProperty("NAME")]
            public string Name { get; set; }

            [JsonProperty("TYPE_ID")]
            public int TypeId { get; set; }

            [JsonProperty("TYPE_NAME")]
            public string TypeName { get; set; }

            [JsonProperty("TAB")]
            public string Tab { get; set; }

            [JsonProperty("PARENT_NAME")]
            public string ParentName { get; set; }

            [JsonProperty("ACTUAL_TOURNAMENT_TYPE")]
            public string ActualTournamentType { get; set; }

            [JsonProperty("ACTUAL_TOURNAMENT_STAGE_ID")]
            public string ActualTournamentStageId { get; set; }

            [JsonProperty("ACTUAL_TOURNAMENT_SEASON_ID")]
            public string ActualTournamentSeasonId { get; set; }

            [JsonProperty("TEAM_ID")]
            public string TeamId { get; set; }

            [JsonProperty("TEAM_PARTICIPANT_TYPE")]
            public int TeamParticipantType { get; set; }

            [JsonProperty("TEAM_IMAGE")]
            public string TeamImage { get; set; }

            [JsonProperty("TEAM_NAME")]
            public string TeamName { get; set; }

            [JsonProperty("SPORT_ID")]
            public SportType SportId { get; set; }
        }
    }
}
