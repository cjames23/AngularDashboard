﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class METRICS_REPORTINGEntities : DbContext
    {
        public METRICS_REPORTINGEntities()
            : base("name=METRICS_REPORTINGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vw_exceptions> vw_exceptions { get; set; }
        public virtual DbSet<vw_LanePicks> vw_LanePicks { get; set; }
        public virtual DbSet<vw_LaneWaves> vw_LaneWaves { get; set; }
        public virtual DbSet<CurrentShippedOrders> CurrentShippedOrders { get; set; }
        public virtual DbSet<vw_AverageOrderAges> vw_AverageOrderAges { get; set; }
        public virtual DbSet<vw_StaleWorkOrderCount> vw_StaleWorkOrderCount { get; set; }
        public virtual DbSet<vw_CurrentErrorRate> vw_CurrentErrorRate { get; set; }
        public virtual DbSet<AgingTotes> AgingTotes { get; set; }
    }
}
