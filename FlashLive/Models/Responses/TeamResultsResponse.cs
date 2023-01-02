using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamResultsResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TeamResultsData[] Data { get; set; }
    }
}
