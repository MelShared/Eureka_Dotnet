using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EUREKA_SOAP_DOTNET_CLIWEB.Models
{
    public class TransaccionModel
    {
        public string CodigoCuenta { get; set; }
        public string ValorMovimiento { get; set; }
        public string Tipo { get; set; }
        public string CuentaDest { get; set; }
    }
}