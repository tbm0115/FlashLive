using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public class TournamentPopularResponse : IResponse
    {
        [JsonProperty("SPORT_ID")]
        public SportType SportId { get; set; }

        [JsonProperty("TEMPLATE_IDS")]
        public string[] TemplateIds { get; set; }
    }
}
