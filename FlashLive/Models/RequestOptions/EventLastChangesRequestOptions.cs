using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class EventLastChangesRequestOptions : IRequestOptions
    {
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int EVENT_ID_MIN = 1;
        internal const int EVENT_ID_MAX = 10;
        [Required, MinLength(EVENT_ID_MIN), MaxLength(EVENT_ID_MAX)]
        public string EventId { get; set; }


        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (string.IsNullOrEmpty(EventId))
            {
                throw new ArgumentException("Must specify event_id");
            }
            else if (EventId.Length < EVENT_ID_MIN)
            {
                throw new ArgumentOutOfRangeException($"event_id must be greater than {EVENT_ID_MIN}");
            }
            else if (EventId.Length > EVENT_ID_MAX)
            {
                throw new ArgumentOutOfRangeException($"event_id must be less than {EVENT_ID_MAX}");
            }
            queryParts.Add($"event_id={EventId}");

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
