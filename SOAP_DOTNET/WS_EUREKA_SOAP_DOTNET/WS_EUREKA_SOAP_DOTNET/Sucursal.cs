//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_EUREKA_SOAP_DOTNET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sucursal()
        {
            this.Asignadoes = new HashSet<Asignado>();
            this.Cuentas = new HashSet<Cuenta>();
        }
    
        public string chr_sucucodigo { get; set; }
        public string vch_sucunombre { get; set; }
        public string vch_sucuciudad { get; set; }
        public string vch_sucudireccion { get; set; }
        public int int_sucucontcuenta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asignado> Asignadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta> Cuentas { get; set; }
    }
}
