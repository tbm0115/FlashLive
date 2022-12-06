using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventPointsHistoryResponse
    {


        public partial class PointsHistory
        {
            public class Item
            {
                [JsonProperty("HOME_RESULT")]
                public string HomeResult { get; set; }

                [JsonProperty("AWAY_RESULT")]
                public string AwayResult { get; set; }

                [JsonProperty("SERVING")]
                public int Serving { get; set; }

                [JsonProperty("LOST_SERVE")]
                public string LostServe { get; set; }

                [JsonProperty("LAST_SCORE")]
                public int LastScore { get; set; }

                [JsonProperty("FIFTEENS_CONTENT")]
                public string FifteensContent { get; set; }
            }
        }
    }
}
