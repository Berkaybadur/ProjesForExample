//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class KargoSirket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KargoSirket()
        {
            this.Kargoes = new HashSet<Kargo>();
            this.SiparisUruns = new HashSet<SiparisUrun>();
        }
    
        public int Id { get; set; }
        public string SirketAd { get; set; }
        public Nullable<int> ilId { get; set; }
        public Nullable<int> ilceId { get; set; }
    
        public virtual ilce ilce { get; set; }
        public virtual iller iller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kargo> Kargoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisUrun> SiparisUruns { get; set; }
    }
}