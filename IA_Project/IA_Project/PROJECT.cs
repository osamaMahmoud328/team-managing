//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IA_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECT()
        {
            this.PRO_ACT = new HashSet<PRO_ACT>();
            this.ACTOR_PROJECT = new HashSet<ACTOR_PROJECT>();
        }
    
        public int PROJECT_ID { get; set; }
        public string NAME_PROJECT { get; set; }
        public string DESC_PROJECT { get; set; }
        public bool P_STATUS { get; set; }
        public System.TimeSpan START_TIME { get; set; }
        public System.TimeSpan END_TIME { get; set; }
        public int PRICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO_ACT> PRO_ACT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTOR_PROJECT> ACTOR_PROJECT { get; set; }
    }
}
