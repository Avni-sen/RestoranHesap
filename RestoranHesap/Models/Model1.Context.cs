﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestoranHesap.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbRestoranEntities1 : DbContext
    {
        public DbRestoranEntities1()
            : base("name=DbRestoranEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_item> tbl_item { get; set; }
        public virtual DbSet<tbl_musteri> tbl_musteri { get; set; }
        public virtual DbSet<tbl_odemesekli> tbl_odemesekli { get; set; }
    }
}