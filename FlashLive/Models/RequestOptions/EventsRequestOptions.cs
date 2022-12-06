using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class EventsRequestOptions<T> : IRequestOptions where T : Event
    {
        /// <summary>
        /// An enumeration
        /// </summary>
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        /// <summary>
        /// EventDataSport id, use `Sports list` endpoint
        /// </summary>
        [Required]
        public virtual SportType Sport { get; set; }

        /// <inheritdoc cref="Sport"/>
        [Required]
        public int SportId => (int)Sport;

        internal const int INDENT_DAYS_MIN = -7;
        internal const int INDENT_DAYS_MAX = 7;
        /// <summary>
        /// Number of days from today. Ex: `-1` yesterday
        /// </summary>
        [Required, Range(INDENT_DAYS_MIN, INDENT_DAYS_MAX)]
        public int IndentDays { get; set; } = 0;

        internal const int TIMEZONE_MIN = -12;
        internal const int TIMEZONE_MAX = 12;
        /// <summary>
        /// Time zone
        /// </summary>
        [Required, Range(TIMEZONE_MIN, TIMEZONE_MAX)]
        public int Timezone { get; set; } = TimeZoneInfo.Local.BaseUtcOffset.Hours;

        public EventsRequestOptions()
        {
            var type = typeof(T);
            if (type == typeof(AmericanFootballEvent))
            {
                Sport = SportType.AMERICAN_FOOTBALL;
            } else if (type == typeof(BaseballEvent)) {
                Sport = SportType.BASEBALL;
            }
        }

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

            if (IndentDays < INDENT_DAYS_MIN || IndentDays > INDENT_DAYS_MAX)
            {
                throw new ArgumentOutOfRangeException($"indent_days must be between {INDENT_DAYS_MIN} and {INDENT_DAYS_MAX}");
            }
            queryParts.Add($"indent_days={IndentDays}");

            if (Timezone < TIMEZONE_MIN || Timezone > TIMEZONE_MAX)
            {
                throw new ArgumentOutOfRangeException($"timezone must be between {TIMEZONE_MIN} and {TIMEZONE_MAX}");
            }
            queryParts.Add($"timezone={Timezone}");

            if (!string.IsNullOrEmpty(uriBuilder.Query))
            {
                uriBuilder.Query += "&" + string.Join("&", queryParts);
            } else {
                uriBuilder.Query = "?" + string.Join("&", queryParts);
            }
        }
    }
}
