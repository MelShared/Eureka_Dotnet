//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_EUREKA_RESTFUL_DOTNET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asignado
    {
        public string chr_asigcodigo { get; set; }
        public string chr_sucucodigo { get; set; }
        public string chr_emplcodigo { get; set; }
        public System.DateTime dtt_asigfechaalta { get; set; }
        public Nullable<System.DateTime> dtt_asigfechabaja { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
