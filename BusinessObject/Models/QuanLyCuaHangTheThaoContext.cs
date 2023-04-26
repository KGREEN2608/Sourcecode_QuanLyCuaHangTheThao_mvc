using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Models
{
    public partial class QuanLyCuaHangTheThaoContext : DbContext
    {
        public QuanLyCuaHangTheThaoContext()
        {
        }

        public QuanLyCuaHangTheThaoContext(DbContextOptions<QuanLyCuaHangTheThaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; } = null!;
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<HangSanXuat> HangSanXuats { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config["ConnectionStrings:DB"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHanh>(entity =>
            {
                entity.HasKey(e => e.MaBaoHanh)
                    .HasName("PK__BaoHanh__A8DF52E5ECC76DB2");

                entity.ToTable("BaoHanh");
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaHoaDon, e.MaSanPham })
                    .HasName("PK__ChiTietH__4CF2A5793C2D5231");

                entity.ToTable("ChiTietHoaDon");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHo__MaHoa__35BCFE0A");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHo__MaSan__36B12243");
            });

            modelBuilder.Entity<HangSanXuat>(entity =>
            {
                entity.HasKey(e => e.MaHangSanXuat)
                    .HasName("PK__HangSanX__977119FC65C5EC68");

                entity.ToTable("HangSanXuat");

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.TenHangSanXuat).HasMaxLength(30);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13BD7E53DE6");

                entity.ToTable("HoaDon");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.HasOne(d => d.MakhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MakhachHang)
                    .HasConstraintName("FK__HoaDon__MakhachH__286302EC");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E54A85941E");

                entity.ToTable("KhachHang");

                entity.Property(e => e.HoTen).HasMaxLength(30);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("sdt");
            });

            modelBuilder.Entity<LoaiHang>(entity =>
            {
                entity.HasKey(e => e.MaLoaiHang)
                    .HasName("PK__LoaiHang__5EEA4160E480F6CC");

                entity.ToTable("LoaiHang");

                entity.Property(e => e.Mota)
                    .HasMaxLength(200)
                    .HasColumnName("mota");

                entity.Property(e => e.TenLoaiHang).HasMaxLength(30);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA47D8FE3C49");

                entity.ToTable("NhanVien");

                entity.Property(e => e.CapBac).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NamSinh).HasColumnType("datetime");

                entity.Property(e => e.TenNhanVien).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D82D62954");

                entity.ToTable("SanPham");

                entity.Property(e => e.ChatLieu).HasMaxLength(50);

                entity.Property(e => e.DoiTuongSuDung).HasMaxLength(30);

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(20);

                entity.Property(e => e.TenHang).HasMaxLength(20);

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.HasOne(d => d.MaBaoHanhNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaBaoHanh)
                    .HasConstraintName("FK__SanPham__MaBaoHa__31EC6D26");

                entity.HasOne(d => d.MaHangSanXuatNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaHangSanXuat)
                    .HasConstraintName("FK__SanPham__MaHangS__32E0915F");

                entity.HasOne(d => d.MaLoaiHangNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiHang)
                    .HasConstraintName("FK__SanPham__MaLoaiH__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
