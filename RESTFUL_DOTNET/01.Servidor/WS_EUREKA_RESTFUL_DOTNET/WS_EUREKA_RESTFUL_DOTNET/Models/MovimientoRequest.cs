﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_EUREKA_RESTFUL_DOTNET.Models
{
    public class MovimientoRequest
    {
        public string CodigoCuenta { get; set; }
        public string ValorMovimiento { get; set; }
        public string Tipo { get; set; }
        public string CuentaDest { get; set; }
    }
}