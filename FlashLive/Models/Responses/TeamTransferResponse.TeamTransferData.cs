using Newtonsoft.Json;
using System;

namespace FlashLive.Models.Responses
{
    public partial class TeamTransferResponse
    {
        public partial class TeamTransferData
        {
            [JsonProperty("DATE")]
            public long Date { get; set; }

            [JsonIgnore]
            public DateTime DateTime => Convert.ToDateTime(Date);

            [JsonProperty("TRANSFER_DIRECTION")]
            public string TransferDirection { get; set; }

            [JsonProperty("TRANSFER_TYPE")]
            public string TransferType { get; set; }

            [JsonProperty("FROM")]
            public Team From { get; set; }

            [JsonProperty("TO")]
            public Team To { get; set; }

            [JsonProperty("PLAYER")]
            public TransferredPlayer Player { get; set; }
        }
    }
}
