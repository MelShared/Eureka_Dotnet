// Controllers/MovimientoController.cs
using System.Web.Mvc;
using EUREKA_SOAP_DOTNET_CLIWEB.MovimientoServicio;
using EUREKA_SOAP_DOTNET_CLIWEB.Models;
using System.Linq;

namespace EUREKA_SOAP_DOTNET_CLIWEB.Controllers
{
    public class MovimientoController : Controller
    {
        private readonly MovimientoServiceClient movimientoService = new MovimientoServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string codigoCuenta)
        {
            var movimientos = movimientoService.ObtenerMovimientosPorCuenta(codigoCuenta);
            var movimientoModels = movimientos.Select(m => new MovimientoModel
            {
                CodigoCuenta = m.CodigoCuenta,
                NumeroMovimiento = m.NumeroMovimiento,
                FechaMovimiento = m.FechaMovimiento,
                CodigoEmpleado = m.CodigoEmpleado,
                CodigoTipoMovimiento = m.CodigoTipoMovimiento,
                ImporteMovimiento = m.ImporteMovimiento
            }).ToList();

            return View(movimientoModels);
        }

        [HttpGet]
        public ActionResult Movimientos(string codigoCuenta)
        {
            var movimientos = movimientoService.ObtenerMovimientosPorCuenta(codigoCuenta);
            var movimientoModels = movimientos.Select(m => new MovimientoModel
            {
                CodigoCuenta = m.CodigoCuenta,
                NumeroMovimiento = m.NumeroMovimiento,
                FechaMovimiento = m.FechaMovimiento,
                CodigoEmpleado = m.CodigoEmpleado,
                CodigoTipoMovimiento = m.CodigoTipoMovimiento,
                ImporteMovimiento = m.ImporteMovimiento
            }).ToList();

            return View(movimientoModels);
        }
    }
}