﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPSCOApplicationServiceCenter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sbContext : DbContext
    {
        public sbContext()
            : base("name=sbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<LinkTable> LinkTables { get; set; }
        public virtual DbSet<View_PowerUsersMatrix> View_PowerUsersMatrix { get; set; }
    }
}