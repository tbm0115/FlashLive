using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    /// <summary>
    /// Upcoming events by <c>tournament_stage_id</c>.
    /// </summary>
    public partial class TournamentFixturesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public TournamentFixturesData[] Data { get; set; }
    }
}
