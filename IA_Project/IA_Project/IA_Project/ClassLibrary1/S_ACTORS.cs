//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_ACTORS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_ACTORS()
        {
            this.ACTOR_PROJECT = new HashSet<ACTOR_PROJECT>();
            this.EVALUATEs = new HashSet<EVALUATE>();
            this.EVALUATEs1 = new HashSet<EVALUATE>();
            this.NOTIFs = new HashSet<NOTIF>();
            this.NOTIFs1 = new HashSet<NOTIF>();
            this.S_PAGE = new HashSet<S_PAGE>();
            this.STAT_REPROT = new HashSet<STAT_REPROT>();
        }
    
        public int ACTOR_ID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string JOB_DESC { get; set; }
        public byte[] PHOTO { get; set; }
        public Nullable<decimal> MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string AROLE { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTOR_PROJECT> ACTOR_PROJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVALUATE> EVALUATEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVALUATE> EVALUATEs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIF> NOTIFs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIF> NOTIFs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_PAGE> S_PAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAT_REPROT> STAT_REPROT { get; set; }
    }
}