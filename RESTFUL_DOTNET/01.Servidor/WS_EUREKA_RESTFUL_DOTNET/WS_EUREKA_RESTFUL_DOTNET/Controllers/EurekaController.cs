using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WS_EUREKA_RESTFUL_DOTNET.Controllers
{
    public class EurekaController : Controller
    {
        // GET: Eureka
        public ActionResult Index()
        {
            return View();
        }
    }
}