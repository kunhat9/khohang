﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoHang.MODEL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyKhoHangEntities : DbContext
    {
        public QuanLyKhoHangEntities()
            : base("name=QuanLyKhoHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppConfig> AppConfigs { get; set; }
        public virtual DbSet<TB_Categories> TB_Categories { get; set; }
        public virtual DbSet<TB_Inventory> TB_Inventory { get; set; }
        public virtual DbSet<TB_InventoryDetails> TB_InventoryDetails { get; set; }
        public virtual DbSet<TB_OrderDetails> TB_OrderDetails { get; set; }
        public virtual DbSet<TB_Orders> TB_Orders { get; set; }
        public virtual DbSet<TB_Products> TB_Products { get; set; }
        public virtual DbSet<TB_Providers> TB_Providers { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
    }
}
