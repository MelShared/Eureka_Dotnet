using EUREKA_RESTFUL_DOTNET_CLIMOV.Model;
using EUREKA_RESTFUL_DOTNET_CLIMOV.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace EUREKA_RESTFUL_DOTNET_CLIMOV.Controller
{
    public class MovimientosController : ContentPage
    {
        public async Task<List<MovimientoViewModel>> LoadMovimientosAsync(string cuenta)
        {
           List<MovimientoViewModel> movimientosList = new List<MovimientoViewModel>();
            if (string.IsNullOrEmpty(cuenta))
            {
                await DisplayAlert("Info", "No cuenta provided", "OK");
                return movimientosList;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://10.40.20.105:667/");
                var response = await client.GetAsync($"Eureka/LeerMovimientos?cuenta={cuenta}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var movimientos = JsonConvert.DeserializeObject<List<MovimientoViewModel>>(result);

                    return movimientos;
                    // Handle the movimientos list, e.g., bind to a ListView
                }
                else
                {
                    await DisplayAlert("Error", "Error retrieving data from server.", "OK");
                    return movimientosList;
                }
            }
        }

        public async Task<bool> CrearMovimientoAsync(MovimientoRequest model)
        {
            if (model == null)
            {
                await DisplayAlert("Error", "Invalid model", "OK");
                return false;
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://10.40.20.105:667/");
                var response = await client.PostAsJsonAsync("Eureka/ProcesarMovimiento", model);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if (bool.TryParse(result, out bool movimientoResult) && movimientoResult)
                    {
                        return true;
                    }
                    else
                    {
                        await DisplayAlert("Error", "Error processing movement", "OK");
                        return false;
                    }
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    await DisplayAlert("Error", "Server error: " + errorContent, "OK");
                    return false;
                }
            }
        }
    }
}