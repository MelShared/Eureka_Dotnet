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
    
    public partial class Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moneda()
        {
            this.Cuentas = new HashSet<Cuenta>();
        }
    
        public string chr_monecodigo { get; set; }
        public string vch_monedescripcion { get; set; }
    
        public virtual CargoMantenimiento CargoMantenimiento { get; set; }
        public virtual CostoMovimiento CostoMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta> Cuentas { get; set; }
        public virtual InteresMensual InteresMensual { get; set; }
    }
}
