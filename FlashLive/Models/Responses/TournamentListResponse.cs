using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentListResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TournamentListData[] Data { get; set; }
    }
}
