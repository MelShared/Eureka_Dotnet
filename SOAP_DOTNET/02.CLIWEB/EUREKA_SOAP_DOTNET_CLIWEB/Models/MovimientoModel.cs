using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EUREKA_SOAP_DOTNET_CLIWEB.Models
{
    public class MovimientoModel
    {
        public string CodigoCuenta { get; set; }
        public int NumeroMovimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string CodigoEmpleado { get; set; }
        public string CodigoTipoMovimiento { get; set; }
        public double ImporteMovimiento { get; set; }
    }
}