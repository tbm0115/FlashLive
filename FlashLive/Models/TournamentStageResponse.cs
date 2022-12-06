using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class TournamentStageResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TournamentStageData Data { get; set; }

        public string LastChangeKey { get; set; }
    }
}
