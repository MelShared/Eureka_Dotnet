using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio;
using EUREKA_SOAP_DOTNET_CLIWEB.MovimientoServicio;
using EUREKA_SOAP_DOTNET_CLIWEB.Models;

public class CuentaController : Controller
{
    private static readonly Dictionary<string, string> TipoMovimientoNombres = new Dictionary<string, string>
    {
        { "003", "Deposito" },
        { "004", "Retiro" },
        { "008", "Tran Ing" },
        { "009", "Tran Sal" },
        { "001", "Creacion" }
    };

    public ActionResult Movimientos(string codigoCuenta)
    {
        if (string.IsNullOrEmpty(codigoCuenta))
        {
            return View(new List<MovimientoModel>());
        }

        var client = new MovimientoServiceClient();
        var movimientos = client.ObtenerMovimientosPorCuenta(codigoCuenta);

        // Mapear CustomMovimientoModel a MovimientoModel
        var movimientoModels = movimientos.Select(m => new MovimientoModel
        {
            CodigoCuenta = m.CodigoCuenta,
            FechaMovimiento = m.FechaMovimiento,
            NumeroMovimiento = m.NumeroMovimiento,
            CodigoEmpleado = m.CodigoEmpleado,
            CodigoTipoMovimiento = TipoMovimientoNombres.ContainsKey(m.CodigoTipoMovimiento) ? TipoMovimientoNombres[m.CodigoTipoMovimiento] : m.CodigoTipoMovimiento,
            ImporteMovimiento = m.ImporteMovimiento
        }).ToList();

        return View(movimientoModels);
    }

    public ActionResult Transaccion()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Transaccion(TransaccionModel model)
    {
        var client = new CuentaServiceClient();
        bool result = client.ActualizarSaldoYRegistrarMovimiento(model.CodigoCuenta, model.ValorMovimiento, model.Tipo, model.CuentaDest);
        if (result)
        {
            ViewBag.Message = "Transacción realizada con éxito.";
        }
        else
        {
            ViewBag.Message = "Error al realizar la transacción.";
        }
        return View(model);
    }
}
