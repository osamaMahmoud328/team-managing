﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IA_ProjectEntities1 : DbContext
    {
        public IA_ProjectEntities1()
            : base("name=IA_ProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PRO_ACT> PRO_ACT { get; set; }
        public virtual DbSet<PROJECT> PROJECTs { get; set; }
        public virtual DbSet<S_ACTORS> S_ACTORS { get; set; }
        public virtual DbSet<S_PAGE> S_PAGE { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<ACTOR_PROJECT> ACTOR_PROJECT { get; set; }
        public virtual DbSet<EVALUATE> EVALUATEs { get; set; }
        public virtual DbSet<NOTIF> NOTIFs { get; set; }
        public virtual DbSet<STAT_REPROT> STAT_REPROT { get; set; }
    }
}
