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
    
    public partial class ACTOR_PROJECT
    {
        public int ACTOR_ID { get; set; }
        public int PROJECT_ID { get; set; }
        public string AROLE { get; set; }
    
        public virtual PROJECT PROJECT { get; set; }
        public virtual S_ACTORS S_ACTORS { get; set; }
    }
}
