
using ConsoulLibrary;
using FlashLive.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;

namespace FlashLive.Playground
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Consoul.Write("Connecting to FlashLive API...");

            var config = new ConfigurationBuilder().AddUserSecrets<ApiConfig>().Build();

            var secretProvider = config.Providers.First();

            secretProvider.TryGet("RapidAPI", out var rapidApiKey);

            using (var wa = new WebAccessor(rapidApiKey))
            {
                var events = wa.GetEventsAsync(new Models.RequestOptions.EventsRequestOptions<AmericanFootballEvent>()
                {
                    Sport = Models.Contracts.Enums.SportType.AMERICAN_FOOTBALL
                }).Result;
                Consoul.Write(JsonConvert.SerializeObject(events), ConsoleColor.Cyan);

            }

            Consoul.Wait();
        }
    }
    public class ApiConfig
    {
        public string RapidApiKey { get; set; }
    }
}