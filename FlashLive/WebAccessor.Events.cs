using FlashLive.Models;
using FlashLive.Models.Contracts;
using FlashLive.Models.Contracts.Enums;
using FlashLive.Models.RequestOptions;
using FlashLive.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashLive
{
    public partial class WebAccessor
    {
        /// <summary>
        /// Get a list of events by <c>sport_id</c>. <c>STAGE_TYPE</c>-main event status, <c>STAGE</c>-more event status.
        /// </summary>
        /// <remarks>Sends an asynchronous web request to the <c>events/list</c> endpoint.</remarks>
        /// <param name="options">Options available for the <c>events/list</c> endpoint.</param>
        /// <returns>Deserialized response</returns>
        public async Task<T[]> GetEventsAsync<T>(EventsRequestOptions<T> options) where T : Event
        {
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/events/list");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventsResponse<T>>(uriBuilder.ToString());

            return response.Data.SelectMany(o => o.Events).ToArray();
        }

        /// <summary>
        /// Gets a list of <see cref="Event"/>s of a particular sports <paramref name="league"/> based on the provided <paramref name="options"/>.
        /// </summary>
        /// <typeparam name="T"><inheritdoc cref="GetEventsAsync{T}(EventsRequestOptions{T})" path="/typeparam[@name='T']"/></typeparam>
        /// <param name="options"><inheritdoc cref="GetEventsAsync{T}(EventsRequestOptions{T})" path="/param[@name='options']"/></param>
        /// <param name="league">Refernce to the sports league to query.</param>
        /// <returns><inheritdoc cref="GetEventsAsync{T}(EventsRequestOptions{T})" path="/returns"/></returns>
        public async Task<T[]> GetEventsAsync<T>(EventsRequestOptions<T> options, string league) where T : Event
        {
            // TODO: Verify this endpoint
            var uriBuilder = new UriBuilder($"{API_ROOT_URI}/{API_VERSION}/{options.Sport}/{league}/events/list");
            options.AddUrlParameters(ref uriBuilder);

            var response = await GetAsync<EventsResponse<T>>(uriBuilder.ToString());

            return response.Data.SelectMany(o => o.Events).ToArray();
        }

        internal static Dictionary<Type, SportType> SportTypeLookup = new Dictionary<Type, SportType>
        {
            { typeof(AmericanFootballEvent), SportType.AMERICAN_FOOTBALL },
            { typeof(BaseballEvent), SportType.BASEBALL }
        };
        internal static SportType GetSport<T>() where T : Event
            => SportTypeLookup.TryGetValue(typeof(T), out SportType result)
                ? result
                : throw new KeyNotFoundException($"Could not find Event type '{typeof(T).Name}'");
    }
}
