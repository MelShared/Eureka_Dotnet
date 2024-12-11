using EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio;
using EUREKA_SOAP_DOTNET_CLIWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EUREKA_SOAP_DOTNET_CLIWEB.Controllers
{
    public class TransaccionController : Controller
    {
        private readonly CuentaServiceClient cuentaService = new CuentaServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TransaccionModel model)
        {
            bool result = cuentaService.ActualizarSaldoYRegistrarMovimiento(model.CodigoCuenta, model.ValorMovimiento, model.Tipo, model.CuentaDest);
            if (result)
            {
                ViewBag.Message = "Transaction successful.";
            }
            else
            {
                ViewBag.Message = "Transaction failed.";
            }
            return View(model);
        }
    }
}