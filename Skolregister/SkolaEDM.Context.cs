﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skolregister
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SkolregisterEntities : DbContext
    {
        public SkolregisterEntities()
            : base("name=SkolregisterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bok> Böcker { get; set; }
        public virtual DbSet<Elev> Elever { get; set; }
        public virtual DbSet<Kurs> Kurser { get; set; }
    }
}