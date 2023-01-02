using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class SportEventCountRequestOptions : IRequestOptions
    {
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int TIMEZONE_MIN = -12;
        internal const int TIMEZONE_MAX = 12;
        /// <summary>
        /// Time zone
        /// </summary>
        [Required, Range(TIMEZONE_MIN, TIMEZONE_MAX)]
        public int Timezone { get; set; } = TimeZoneInfo.Local.BaseUtcOffset.Hours;

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (Timezone < TIMEZONE_MIN || Timezone > TIMEZONE_MAX)
            {
                throw new ArgumentOutOfRangeException($"timezone must be between {TIMEZONE_MIN} and {TIMEZONE_MAX}");
            }
            queryParts.Add($"timezone={Timezone}");

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
