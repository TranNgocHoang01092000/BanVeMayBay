﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightTicket.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A6C0B2_Nhom13FlightTicketEntities : DbContext
    {
        public DB_A6C0B2_Nhom13FlightTicketEntities()
            : base("name=DB_A6C0B2_Nhom13FlightTicketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietChuyenBay> ChiTietChuyenBays { get; set; }
        public virtual DbSet<ChoNgoi> ChoNgois { get; set; }
        public virtual DbSet<ChuyenBay> ChuyenBays { get; set; }
        public virtual DbSet<DoanhThuBanVe> DoanhThuBanVes { get; set; }
        public virtual DbSet<DoanhThuNam> DoanhThuNams { get; set; }
        public virtual DbSet<DonGia> DonGias { get; set; }
        public virtual DbSet<HangVe> HangVes { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SanBay> SanBays { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VeChuyenBay> VeChuyenBays { get; set; }
    }
}
