using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EUREKA_RESTFUL_DOTNET_CLIMOV.Model
{
    public class MovimientoViewModel
    {
        public string Cuenta { get; set; }
        public int NroMov { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Accion { get; set; }
        public decimal Importe { get; set; }
    }
}