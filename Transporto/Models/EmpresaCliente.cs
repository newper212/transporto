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
    
    public partial class EmpresaCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpresaCliente()
        {
            this.Contactos = new HashSet<Contactos>();
            this.HojaDeRuta = new HashSet<HojaDeRuta>();
        }
    
        public int IDEmpresaCliente { get; set; }
        public string Ruc { get; set; }
        public string NombreEmpresa { get; set; }
        public string TelefonoCorporativo { get; set; }
        public string Direccion { get; set; }
        public int IDDistrito { get; set; }
        public string EmailCorporativa { get; set; }
        public string Observaciones { get; set; }
        public string DNIContaco { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string CelularContacto { get; set; }
        public string EmailContaco { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }
        public virtual Distrito Distrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HojaDeRuta> HojaDeRuta { get; set; }
    }
}
