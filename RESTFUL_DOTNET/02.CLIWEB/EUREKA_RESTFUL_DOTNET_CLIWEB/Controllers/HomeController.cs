using System.Web.Http.Cors;
using System.Web.Mvc;

namespace EUREKA_RESTFUL_DOTNET_CLIWEB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Movimientos()
        {
            return View();
        }
    }
}