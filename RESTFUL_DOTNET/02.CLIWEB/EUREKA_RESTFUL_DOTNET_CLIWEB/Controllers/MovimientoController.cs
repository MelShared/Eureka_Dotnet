using EUREKA_RESTFUL_DOTNET_CLIWEB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EUREKA_RESTFUL_DOTNET_CLIWEB.Controllers
{
    public class MovimientosController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:667/");
                var response = await client.GetAsync("Eureka/LeerMovimientos?cuenta=00100001");
                var result = await response.Content.ReadAsStringAsync();
                var movimientos = JsonConvert.DeserializeObject<List<MovimientoViewModel>>(result);
                return View(movimientos);
            }
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Crear(MovimientoRequest model)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:667/");
                    var response = await client.PostAsJsonAsync("Eureka/ProcesarMovimiento", model);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        if (bool.TryParse(result, out bool movimientoResult) && movimientoResult)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Error processing movement");
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