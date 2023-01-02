using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamNewsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TeamNewsData[] Data { get; set; }
    }
}
