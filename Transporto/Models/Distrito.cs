//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transporto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distrito()
        {
            this.EmpresaCliente = new HashSet<EmpresaCliente>();
            this.HojaDeRuta = new HashSet<HojaDeRuta>();
        }
    
        public int IDDistrito { get; set; }
        public string NombreDistrito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCliente> EmpresaCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HojaDeRuta> HojaDeRuta { get; set; }
    }
}
