using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Sport[] Data { get; set; }
    }
}
