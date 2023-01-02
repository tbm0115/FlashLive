using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportEventCountResponse : IResponse
    {
        [JsonProperty("DATA")]
        public SportEventCountData Data { get; set; }
    }
}
