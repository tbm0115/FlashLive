using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public class MultiSearchResponse : IResponse
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("SPORT_ID")]
        public SportType SportId { get; set; }

        [JsonProperty("FAVOURITE_KEY")]
        public string FavouriteKey { get; set; }

        /// <summary>
        /// Refers to country flag.
        /// </summary>
        [JsonProperty("FLAG_ID")]
        public int FlagId { get; set; }

        [JsonProperty("COUNTRY_ID")]
        public int CountryId { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty("IMAGE")]
        public string Image { get; set; }

        [JsonProperty("PARTICIPANT_TYPE_ID")]
        public ParticipantType ParticipantTypeId { get; set; }

        [JsonProperty("GENDER_ID")]
        public int GenderId { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("COUNTRY_NAME")]
        public string CountryName { get; set; }

        [JsonProperty("TITLE")]
        public string Title { get; set; }

        // TODO: Add TOURNAMENT_STAGE_IDS_WITH_STATS_DATA
    }
}
