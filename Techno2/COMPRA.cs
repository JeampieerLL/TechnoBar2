//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Techno2
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA()
        {
            this.DETALLE_COMPRA = new HashSet<DETALLE_COMPRA>();
        }
    
        public string ID_compra { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string numero_comprobante { get; set; }
        public string ID_admin { get; set; }
        public System.DateTime FECHA { get; set; }
        public string ID_PROVEEDOR { get; set; }
    
        public virtual ADMINISTRADOR ADMINISTRADOR { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
    }
}
