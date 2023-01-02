using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class MultiSearchRequestOptions : IRequestOptions
    {
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        internal const int QUERY_MIN = 2;
        internal const int QUERY_MAX = 50;
        [Required, MinLength(QUERY_MIN), MaxLength(QUERY_MAX)]
        public string Query { get; set; }

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (string.IsNullOrEmpty(Query))
            {
                throw new ArgumentException("Must specify query");
            }
            else if (Query.Length < QUERY_MIN)
            {
                throw new ArgumentOutOfRangeException($"query must be greater than {QUERY_MIN}");
            }
            else if (Query.Length > QUERY_MAX)
            {
                throw new ArgumentOutOfRangeException($"query must be less than {QUERY_MAX}");
            }
            queryParts.Add($"query={Query}");

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
