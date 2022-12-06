using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventResponse
    {
        public class EventMeta
        {
            [JsonProperty("BOOKMAKERS")]
            public Bookmaker[] Bookmakers { get; set; }

            public class Bookmaker
            {
                [JsonProperty("BOOKMAKER_ID")]
                public int BookmakerId { get; set; }

                [JsonProperty("TYPE_BET")]
                public string TypeBet { get; set; }

                [JsonProperty("SD")]
                public string SD { get; set; }
            }
        }
    }
}
