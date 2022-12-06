using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventNewsResponse
    {

        public partial class EventNews
        {
            public class NewsLink
            {
                [JsonProperty("IMAGE_VARIANT_ID")]
                public int ImageVariantId { get; set; }

                [JsonProperty("IMAGE_VARIANT_URL")]
                public string ImageVariantUrl { get; set; }
            }
        }
    }
}
