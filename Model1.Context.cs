﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.Veri
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PERSONEL_TAKIPEntities : DbContext
    {
        public PERSONEL_TAKIPEntities()
            : base("name=PERSONEL_TAKIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Cikislar> tbl_Cikislar { get; set; }
        public virtual DbSet<tbl_Girisler> tbl_Girisler { get; set; }
        public virtual DbSet<tbl_Izinler> tbl_Izinler { get; set; }
        public virtual DbSet<tbl_IzinTur> tbl_IzinTur { get; set; }
        public virtual DbSet<tbl_Kullanicilar> tbl_Kullanicilar { get; set; }
        public virtual DbSet<tbl_Mesai> tbl_Mesai { get; set; }
        public virtual DbSet<tbl_Pozisyon> tbl_Pozisyon { get; set; }
        public virtual DbSet<tbl_Proje> tbl_Proje { get; set; }
        public virtual DbSet<tbl_ProjeBilgileri> tbl_ProjeBilgileri { get; set; }
        public virtual DbSet<tbl_Sirketler> tbl_Sirketler { get; set; }
    }
}