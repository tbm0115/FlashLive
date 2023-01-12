using FlashLive.Models.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FlashLive.Models.Responses
{
    public class EventLastChangesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public Dictionary<string, string> Data { get; set; }
    }
}
