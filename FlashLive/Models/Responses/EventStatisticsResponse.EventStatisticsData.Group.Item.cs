using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventStatisticsResponse
    {

        public partial class EventStatisticsData
        {

            public partial class Group
            {
                public class Item
                {
                    [JsonProperty("INCIDENT_NAME")]
                    public string IncidentName { get; set; }

                    [JsonProperty("VALUE_HOME")]
                    public string ValueHome { get; set; }

                    [JsonProperty("VALUE_AWAY")]
                    public string ValueAway { get; set; }
                }
            }
        }
    }
}
