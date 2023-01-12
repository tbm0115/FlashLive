using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class TeamFixturesRequestOptions : IRequestOptions
    {
        internal const int TEAM_ID_MIN = 1;
        internal const int TEAM_ID_MAX = 10;
        [Required, MinLength(TEAM_ID_MIN), MaxLength(TEAM_ID_MAX)]
        public string TeamId { get; set; }

        [Required]
        public SportType Sport { get; set; }
        [Required]
        public int SportId => (int)Sport;

        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int PAGE_MIN = 1;
        internal const int PAGE_MAX = 1_000;
        /// <summary>
        /// Page number
        /// </summary>
        [Range(PAGE_MIN, PAGE_MAX)]
        public int Page { get; set; } = 1;

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (SportId <= 0)
            {
                throw new ArgumentException("Must specify sport_id");
            }
            queryParts.Add($"sport_id={SportId}");

            if (string.IsNullOrEmpty(TeamId))
            {
                throw new ArgumentException("Must specify team_id");
            }
            else if (TeamId.Length < TEAM_ID_MIN)
            {
                throw new ArgumentOutOfRangeException($"team_id must be greater than {TEAM_ID_MIN}");
            }
            else if (TeamId.Length > TEAM_ID_MAX)
            {
                throw new ArgumentOutOfRangeException($"team_id must be less than {TEAM_ID_MAX}");
            }
            queryParts.Add($"team_id={TeamId}");

            if (Page < PAGE_MIN)
            {
                throw new ArgumentOutOfRangeException($"page must be greater than {PAGE_MIN}");
            } else if (Page > PAGE_MAX)
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
