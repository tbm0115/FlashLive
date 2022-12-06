using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<TeamResponse.Team> GetTeamAsync(TeamRequestOptions options)
        {
            // teams/data
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/team/data");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
