using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class EventData<T> where T : Event
    {
        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("HEADER")]
        public string Header { get; set; }

        [JsonProperty("NAME_PART_1")]
        public string NamePart1 { get; set; }

        [JsonProperty("NAME_PART_2")]
        public string NamePart2 { get; set; }

        [JsonProperty("TOURNAMENT_TEMPLATE_ID")]
        public string TournamentTemplateId { get; set; }

        [JsonProperty("COUNTRY_ID")]
        public int CountryId { get; set; }

        [JsonProperty("COUNTRY_NAME")]
        public string CountryName { get; set; }

        [JsonProperty("EVENTS")]
        public T[] Events { get; set; }
    }
}
