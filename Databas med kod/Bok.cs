//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Databas_med_kod
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bok()
        {
            this.Boklån = new HashSet<Boklån>();
        }
    
        public int BokNr { get; set; }
        public string Titel { get; set; }
        public string Ämne { get; set; }
        public string Författare { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boklån> Boklån { get; set; }
    }
}