﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVEntityProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CVEntityEntities : DbContext
    {
        public CVEntityEntities()
            : base("name=CVEntityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_ADRES> Tbl_ADRES { get; set; }
        public virtual DbSet<Tbl_CALISMALAR> Tbl_CALISMALAR { get; set; }
        public virtual DbSet<Tbl_HAKKIMDA> Tbl_HAKKIMDA { get; set; }
        public virtual DbSet<Tbl_ILETISIM> Tbl_ILETISIM { get; set; }
        public virtual DbSet<Tbl_YETENEKLER> Tbl_YETENEKLER { get; set; }
        public virtual DbSet<Tbl_ADMİN> Tbl_ADMİN { get; set; }
    }
}