using FlashLive.Models.Contracts;
using Newtonsoft.Json;
using System.Security.Principal;

namespace FlashLive.Models.Responses
{
    public partial class TeamFixturesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TeamFixture[] Data { get; set; }
    }
}
