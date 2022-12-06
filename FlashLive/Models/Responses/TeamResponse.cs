using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Team Data { get; set; }
    }
}
