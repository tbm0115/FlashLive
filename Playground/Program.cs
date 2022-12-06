﻿
using ConsoulLibrary;
using FlashLive.Models;
using Newtonsoft.Json;
using System;

namespace FlashLive.Playground
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Consoul.Write("Connecting to ESPN NFL Scoreboard...");

            using (var wa = new WebAccessor(""))
            {
                var events = wa.GetEventsAsync(new Models.RequestOptions.EventRequestOptions<BaseballEvent>()
                {
                    Sport = Models.Contracts.Enums.SportType.BASEBALL
                }).Result;
                Consoul.Write(JsonConvert.SerializeObject(events), ConsoleColor.Cyan);

            }

            Consoul.Wait();
        }
    }
}