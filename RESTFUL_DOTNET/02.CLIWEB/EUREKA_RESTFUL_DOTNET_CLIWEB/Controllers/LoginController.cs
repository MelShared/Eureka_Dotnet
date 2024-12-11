using System.Web.Mvc;
using EUREKA_RESTFUL_DOTNET_CLIWEB.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EUREKA_RESTFUL_DOTNET_CLIWEB.Models;
using System;

namespace EUREKA_RESTFUL_DOTNET_CLIWEB.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
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
                                return RedirectToAction("Index", "Movimientos");
                            }
                            else
                            {
                                ModelState.AddModelError("", "Invalid username or password");
                            }
                        }
                        catch (JsonReaderException ex)
                        {
                            ModelState.AddModelError("", "Error parsing response from server: " + ex.Message);
                        }
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ModelState.AddModelError("", "Server error: " + errorContent);
                    }
                }
            }
            return View(model);
        }
    }
}