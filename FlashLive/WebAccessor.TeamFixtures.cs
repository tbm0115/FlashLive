using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        public async Task<TeamFixturesResponse.TeamFixture[]> GetTeamFixturesAsync(TeamFixturesRequestOptions options)
        {
            // teams/fixtures
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/teams/fixtures");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<TeamFixturesResponse>(uriBuilder.ToString());

            return response.Data;
        }
    }
}
