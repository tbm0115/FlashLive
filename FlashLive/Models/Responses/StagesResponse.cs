using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class StagesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Stage[] Data { get; set; }
    }
}
