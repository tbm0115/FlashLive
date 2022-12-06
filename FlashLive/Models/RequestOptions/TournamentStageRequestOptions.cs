using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlashLive.Models.RequestOptions
{
    public class TournamentStageRequestOptions : IRequestOptions
    {
        /// <summary>
        /// Tournament stage id.
        /// </summary>
        [Required]
        public string TournamentStageId { get; set; }

        /// <summary>
        /// An enumeration
        /// </summary>
        [Required]
        public LocaleType Locale { get; set; } = LocaleType.en_INT;


        public void AddUrlParameters(ref UriBuilder uriBuilder)
        {
            List<string> queryParts = new List<string>
            {
                $"locale={Locale}"
            };

            if (string.IsNullOrEmpty(TournamentStageId))
            {
                throw new ArgumentNullException("Must specify tournament_stage_id");
            }
            queryParts.Add($"tournament_stage_id={TournamentStageId}");

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
