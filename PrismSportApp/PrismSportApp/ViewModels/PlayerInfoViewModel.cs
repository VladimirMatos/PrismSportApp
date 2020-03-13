using PrismSportApp.Models;
using Prism.Services;
using PrismSportApp.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace PrismSportApp.ViewModels
{
    public class PlayerInfoViewModel
    {
        IApiServices _apiService = new ApiService();
        public string PlayersInfo { get; set; }
        public PlayerInfo Info { get; set; }

       
        public PlayerInfoViewModel()
        { 
            GetDataAysnc();
        }
        async Task GetDataAysnc()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    Info = await _apiService.GetPlayerInfo();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
            else
            {
                
            }

        }

    }
}
