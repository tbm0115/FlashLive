using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SeasonResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Season[] Data { get; set; }
    }
}
