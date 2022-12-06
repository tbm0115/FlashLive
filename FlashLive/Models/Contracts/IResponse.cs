using Newtonsoft.Json;

namespace FlashLive.Models.Contracts
{
    public interface IResponse
    {
        [JsonProperty("LAST_CHANGE_KEY")]
        public string LastChangeKey { get; set; }
    }
}
