using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class TournamentPopularRequestOptions : IRequestOptions
    {
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;

        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

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
