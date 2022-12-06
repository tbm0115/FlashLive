using FlashLive.Models.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashLive.Models
{
    public class AmericanFootballEvent : Event
    {
        [JsonProperty("AWAY_SCORE_PART_1")]
        public string AwayScorePart1 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_2")]
        public string AwayScorePart2 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_3")]
        public string AwayScorePart3 { get; set; }

        [JsonProperty("AWAY_SCORE_PART_4")]
        public string AwayScorePart4 { get; set; }

        [JsonProperty("HOME_SCORE_PART_1")]
        public string HomeScorePart1 { get; set; }

        [JsonProperty("HOME_SCORE_PART_2")]
        public string HomeScorePart2 { get; set; }

        [JsonProperty("HOME_SCORE_PART_3")]
        public string HomeScorePart3 { get; set; }

        [JsonProperty("HOME_SCORE_PART_4")]
        public string HomeScorePart4 { get; set; }
    }
}
