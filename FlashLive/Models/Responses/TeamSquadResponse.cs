using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamSquadResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TeamSquadData[] Data { get; set; }
    }
}
