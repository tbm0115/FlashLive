using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class TeamRequestOptions : IRequestOptions
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

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

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

            if (SportId <= 0)
            {
                throw new ArgumentException("Must specify sport_id");
            }
            queryParts.Add($"sport_id={SportId}");

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
