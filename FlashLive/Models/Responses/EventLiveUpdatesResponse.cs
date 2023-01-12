using FlashLive.Models.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FlashLive.Models.Responses
{
    public class EventLiveUpdatesResponse : IResponse
    {
        [JsonProperty("DATA")]
        public List<Dictionary<string, string>> Data { get; set; } = new List<Dictionary<string, string>>();
    }
}
