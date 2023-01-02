using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TeamTransferResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TeamTransferData[] Data { get; set; }
    }
}
