﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Module6.EventSourcing.Infrastructure.Persistence.SqlServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class expoware_MerloEntities : DbContext
    {
        public expoware_MerloEntities()
            : base("name=expoware_MerloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Court> Courts { get; set; }
    }
}