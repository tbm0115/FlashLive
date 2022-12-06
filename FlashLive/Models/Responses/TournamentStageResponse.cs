using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentStageResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TournamentStageData Data { get; set; }
    }
}
