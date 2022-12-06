using FlashLive.Models.Contracts;
using Newtonsoft.Json;

namespace FlashLive.Models
{
    public class BaseballEvent : Event
    {
        [JsonProperty("HOME_HITS")]
        public int HomeHits { get; set; }

        [JsonProperty("AWAY_HITS")]
        public int AwayHits { get; set; }

        [JsonProperty("HOME_ERRORS")]
        public int HomeErrors { get; set; }

        [JsonProperty("AWAY_ERRORS")]
        public int AwayErrors { get; set; }

        [JsonProperty("AWAY_SCORE_PART_1")]
        public string AwayScorePart1 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_2")]
        public string AwayScorePart2 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_3")]
        public string AwayScorePart3 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_4")]
        public string AwayScorePart4 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_5")]
        public string AwayScorePart5 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_6")]
        public string AwayScorePart6 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_7")]
        public string AwayScorePart7 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_8")]
        public string AwayScorePart8 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_9")]
        public string AwayScorePart9 { get; set; }

        [JsonProperty("HOME_SCORE_PART_1")]
        public string HomeScorePart1 { get; set; }

        [JsonProperty("HOME_SCORE_PART_2")]
        public string HomeScorePart2 { get; set; }

        [JsonProperty("HOME_SCORE_PART_3")]
        public string HomeScorePart3 { get; set; }

        [JsonProperty("HOME_SCORE_PART_4")]
        public string HomeScorePart4 { get; set; }

        [JsonProperty("HOME_SCORE_PART_5")]
        public string HomeScorePart5 { get; set; }

        [JsonProperty("HOME_SCORE_PART_6")]
        public string HomeScorePart6 { get; set; }

        [JsonProperty("HOME_SCORE_PART_7")]
        public string HomeScorePart7 { get; set; }

        [JsonProperty("HOME_SCORE_PART_8")]
        public string HomeScorePart8 { get; set; }

        [JsonProperty("HOME_SCORE_PART_9")]
        public string HomeScorePart9 { get; set; }
    }
}
