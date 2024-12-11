using System.Web.Mvc;
using EUREKA_SOAP_DOTNET_CLIWEB.LoginServicio;
using EUREKA_SOAP_DOTNET_CLIWEB.Models;

public class LoginController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            var client = new LoginServiceClient();
            bool isAuthenticated = client.Login(model.Username, model.Password);
            if (isAuthenticated)
            {
                return RedirectToAction("Movimientos", "Cuenta");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
        }
        return View(model);
    }
}
