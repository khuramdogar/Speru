﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SperuPanel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SperuEntities : DbContext
    {
        public SperuEntities()
            : base("name=SperuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminlogin> adminlogins { get; set; }
        public virtual DbSet<speruhelp> speruhelps { get; set; }
        public virtual DbSet<sperunew> sperunews { get; set; }
    }
}