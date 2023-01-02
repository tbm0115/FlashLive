using Newtonsoft.Json;

namespace FlashLive.Models.Responses
{
    public partial class TournamentListResponse
    {

        public partial class TournamentListData
        {
            public class TournamentStage
            {
                /// <remarks>Foreign key to <see cref="StagesResponse.Stage.StageId"/></remarks>
                [JsonProperty("STAGE_ID")]
                public string StageId { get; set; }

                [JsonProperty("STAGE_NAME")]
                public string StageName { get; set; }

                [JsonProperty("OUT")]
                public string Out { get; set; }
            }
        }
    }
}
