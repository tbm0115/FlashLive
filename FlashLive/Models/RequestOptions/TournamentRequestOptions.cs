using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class TournamentRequestOptions : IRequestOptions
    {
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int TOURNAMENT_STAGE_ID_MIN = 1;
        internal const int TOURNAMENT_STAGE_ID_MAX = 10;
        [Required, MinLength(TOURNAMENT_STAGE_ID_MIN), MaxLength(TOURNAMENT_STAGE_ID_MAX)]
        public string TournamentStageId { get; set; }

        internal const int PAGE_MIN = 1;
        internal const int PAGE_MAX = 1_000;
        [Range(PAGE_MIN, PAGE_MAX)]
        public int Page { get; set; } = 1;

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (string.IsNullOrEmpty(TournamentStageId))
            {
                throw new ArgumentException("Must specify tournament_stage_id");
            }
            else if (TournamentStageId.Length < TOURNAMENT_STAGE_ID_MIN)
            {
                throw new ArgumentOutOfRangeException($"tournament_stage_id must be greater than {TOURNAMENT_STAGE_ID_MIN}");
            }
            else if (TournamentStageId.Length > TOURNAMENT_STAGE_ID_MAX)
            {
                throw new ArgumentOutOfRangeException($"tournament_stage_id must be less than {TOURNAMENT_STAGE_ID_MAX}");
            }
            queryParts.Add($"tournament_stage_id={TournamentStageId}");

            if (Page < PAGE_MIN)
            {
                throw new ArgumentOutOfRangeException($"page must be greater than {PAGE_MIN}");
            }
            else if (Page > PAGE_MAX)
            {
                throw new ArgumentOutOfRangeException($"page must be less than {PAGE_MAX}");
            }
            queryParts.Add($"page={Page}");

            if (!string.IsNullOrEmpty(uriBuilder.Query))
            {
                uriBuilder.Query += "&" + string.Join("&", queryParts);
            }
            else
            {
                uriBuilder.Query = "?" + string.Join("&", queryParts);
            }
        }
    }
}
