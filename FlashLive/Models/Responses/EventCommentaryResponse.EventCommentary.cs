using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class EventCommentaryResponse
    {
        public class EventCommentary
        {
            [JsonProperty("COMMENT_TIME")]
            public string CommentTime { get; set; }

            [JsonProperty("COMMENT_CLASS")]
            public string CommentClass { get; set; }

            [JsonProperty("COMMENT_TEXT")]
            public string CommentText { get; set; }

            [JsonProperty("COMMENT_IS_BOLD")]
            public string CommentIsBold { get; set; }

            [JsonProperty("COMMENT_IS_IMPORTANT")]
            public int CommentIsImportant { get; set; }

            [JsonProperty("HIGHLIGHT_IMAGE_RESOLUTION")]
            public string HighlightImageResolution { get; set; }

            [JsonProperty("HIGHLIGHT_IMAGE_URL")]
            public string HighlightImageUrl { get; set; }

            [JsonProperty("ML")]
            public string ML { get; set; }

            [JsonProperty("MM")]
            public string MM { get; set; }
        }
    }
}
