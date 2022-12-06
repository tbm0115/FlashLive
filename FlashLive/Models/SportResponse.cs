using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class SportResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Sport[] Data { get; set; }

        public string LastChangeKey { get; set; }
    }
}
