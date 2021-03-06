﻿using Newtonsoft.Json;
using PrismSportApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PrismSportApp
{
    public class ApiService: IApiServices
    {
        Links Links { get; set; } = new Links();
        public async Task<Team> GetId(int id)
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(Links.Team);
            return JsonConvert.DeserializeObject<Team>(result);

        }
        public async Task<Fixtures> GetFixturesWorldCup() //WorldCup//
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-auth-token", "78425d5d244f4ad4a4cb1d864b9ee167");
            string text = await httpClient.GetStringAsync(Links.WorldCup);
            return JsonConvert.DeserializeObject<Fixtures>(text);

        }
        public async Task<Fixtures> GetFixturesUefaChampions() //UefaChampions//
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-auth-token", "78425d5d244f4ad4a4cb1d864b9ee167");
            string text = await httpClient.GetStringAsync(Links.Champions);
            return JsonConvert.DeserializeObject<Fixtures>(text);

        }
        public async Task<Fixtures> GetFixturesBundesliga() //Bundesliga//
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-auth-token", "78425d5d244f4ad4a4cb1d864b9ee167");
            string text = await httpClient.GetStringAsync(Links.Bundesliga);
            return JsonConvert.DeserializeObject<Fixtures>(text);

        }
        public async Task<Competitions> GetLeagues()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-auth-token", "78425d5d244f4ad4a4cb1d864b9ee167");
            string text = await httpClient.GetStringAsync(Links.Leagues);
            return JsonConvert.DeserializeObject<Competitions>(text);

        }
        public async Task<PlayerInfo> GetPlayerInfo()
        {

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-auth-token", "66cf3c4e56174af1a3f83256d0750e9c");
            string text = await httpClient.GetStringAsync(Links.PlayerInfo);
            return JsonConvert.DeserializeObject<PlayerInfo>(text);

        }
    }
}
