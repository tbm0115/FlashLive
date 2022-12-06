using FlashLive.Models.Contracts;
using System;
using System.Collections.Generic;
using FlashLive.Models.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class SeasonRequestOptions : IRequestOptions
    {
        /// <summary>
        /// An enumeration
        /// </summary>
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int SEASON_ID_MIN = 1;
        internal const int SEASON_ID_MAX = 10;
        /// <summary>
        /// Season tournmant id
        /// </summary>
        [Required, MinLength(SEASON_ID_MIN), MaxLength(SEASON_ID_MAX)]
        public string SeasonId { get; set; }

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (string.IsNullOrEmpty(SeasonId))
            {
                throw new ArgumentException("Must specify season_id");
            } else if (SeasonId.Length < SEASON_ID_MIN)
            {
                throw new ArgumentOutOfRangeException($"season_id must be greater than {SEASON_ID_MIN}");
            } else if (SeasonId.Length > SEASON_ID_MAX)
            {
                throw new ArgumentOutOfRangeException($"season_id must be less than {SEASON_ID_MAX}");
            }
            queryParts.Add($"season_id={SeasonId}");

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
