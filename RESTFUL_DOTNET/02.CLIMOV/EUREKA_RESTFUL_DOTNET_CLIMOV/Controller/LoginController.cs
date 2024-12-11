using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using EUREKA_RESTFUL_DOTNET_CLIMOV.Model;
using Microsoft.Maui.Controls;

namespace EUREKA_RESTFUL_DOTNET_CLIMOV.Controller
{
    public class LoginController : ContentPage
    {
        public async Task<bool> LoginAsync(LoginViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password))
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://10.40.20.105:667/");
                    var response = await client.PostAsJsonAsync("Login/login", model);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        try
                        {
                            var loginResult = JsonConvert.DeserializeObject<dynamic>(result);

                            if (loginResult.success == true)
                            {
                                return true;
                            }
                            else
                            {
                                await DisplayAlert("Error", "Invalid username or password", "OK");
                                return false;
                            }
                        }
                        catch (JsonReaderException ex)
                        {
                            await DisplayAlert("Error", "Error parsing response from server: " + ex.Message, "OK");
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
            else
            {
                await DisplayAlert("Error", "Username and Password cannot be empty", "OK");
                return false;
            }
        }
    }
}