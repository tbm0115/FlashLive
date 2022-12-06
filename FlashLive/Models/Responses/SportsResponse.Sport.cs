using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class SportsResponse
    {
        public class Sport
        {
            [JsonProperty("ID")]
            public int Id { get; set; }

            [JsonProperty("NAME")]
            public string Name { get; set; }
        }
    }
}
