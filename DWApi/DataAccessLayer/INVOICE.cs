//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class INVOICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVOICE()
        {
            this.DETAIL_INVOICE = new HashSet<DETAIL_INVOICE>();
        }
    
        public int id_invoice { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> id_saller { get; set; }
        public Nullable<bool> enabled { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAIL_INVOICE> DETAIL_INVOICE { get; set; }
        public virtual SALLER SALLER { get; set; }
    }
}