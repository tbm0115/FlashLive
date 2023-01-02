using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TournamentData[] Data { get; set; }
    }
}
