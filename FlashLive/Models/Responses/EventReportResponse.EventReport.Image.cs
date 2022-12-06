using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventReportResponse
    {

        public partial class EventReport
        {
            public class Image
            {
                [JsonProperty("IVW")]
                public int IVW { get; set; }

                [JsonProperty("IMAGE_VARIANT_URL")]
                public string ImageVariantUrl { get; set; }
            }
        }
    }
}
