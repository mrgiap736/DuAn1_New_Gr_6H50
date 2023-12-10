using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.DomainClass;

namespace DAL.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DaoDien> DaoDiens { get; set; } = null!;
        public virtual DbSet<DichVu> DichVus { get; set; } = null!;
        public virtual DbSet<DienVien> DienViens { get; set; } = null!;
        public virtual DbSet<Ghe> Ghes { get; set; } = null!;
        public virtual DbSet<HangGhe> HangGhes { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LichChieu> LichChieus { get; set; } = null!;
        public virtual DbSet<Phim> Phims { get; set; } = null!;
        public virtual DbSet<PhongChieu> PhongChieus { get; set; } = null!;
        public virtual DbSet<TheLoai> TheLoais { get; set; } = null!;
        public virtual DbSet<TheThanhVien> TheThanhViens { get; set; } = null!;
        public virtual DbSet<ThongKe> ThongKes { get; set; } = null!;
        public virtual DbSet<Ve> Ves { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

=======
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.-và-thẻ-thành-viê
=======
                optionsBuilder.UseSqlServer("Data Source=MRG;Initial Catalog=Moviet_Fixed;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaoDien>(entity =>
            {
                entity.HasKey(e => e.MaDaoDien)
                    .HasName("PK__DaoDien__F57FCFF48125469F");

                entity.Property(e => e.MaDaoDien).IsFixedLength();
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.HasKey(e => e.MaDichVu)
                    .HasName("PK__DichVu__C0E6DE8FFBBEBB6B");

                entity.Property(e => e.MaDichVu).IsFixedLength();
            });

            modelBuilder.Entity<DienVien>(entity =>
            {
                entity.HasKey(e => e.MaDienVien)
                    .HasName("PK__DienVien__28BD9B0C86E25EE2");

                entity.Property(e => e.MaDienVien).IsFixedLength();
            });

            modelBuilder.Entity<Ghe>(entity =>
            {
                entity.HasKey(e => e.MaGhe)
                    .HasName("PK__Ghe__3CD3C67BAA187266");

                entity.Property(e => e.MaGhe).IsFixedLength();

                entity.HasOne(d => d.MaHangGheNavigation)
                    .WithMany(p => p.Ghes)
                    .HasForeignKey(d => d.MaHangGhe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ghe__MaHangGhe__276EDEB3");
            });

            modelBuilder.Entity<HangGhe>(entity =>
            {
                entity.HasKey(e => e.MaHangGhe)
                    .HasName("PK__HangGhe__9774DC53A1BFA286");

                entity.Property(e => e.MaHangGhe).ValueGeneratedNever();
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B0A55681F");

                entity.Property(e => e.MaHoaDon).IsFixedLength();

                entity.Property(e => e.MaVoucher).IsFixedLength();

                entity.Property(e => e.SdtkhachHang).IsFixedLength();

                entity.HasOne(d => d.MaVoucherNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaVoucher)
                    .HasConstraintName("FK__HoaDon__MaVouche__6754599E");

                entity.HasOne(d => d.SdtkhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.SdtkhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__SDTKhach__66603565");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__6C2FD0CE96ED15C3");

                entity.Property(e => e.MaHoaDonChiTiet).IsFixedLength();

                entity.Property(e => e.MaDichVu).IsFixedLength();

                entity.Property(e => e.MaHoaDon).IsFixedLength();

                entity.Property(e => e.MaVe).IsFixedLength();

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaDichVu)
                    .HasConstraintName("FK__HoaDonChi__MaDic__6D0D32F4");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaHoa__6B24EA82");

                entity.HasOne(d => d.MaVeNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaVe)
                    .HasConstraintName("FK__HoaDonChiT__MaVe__6C190EBB");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.SdtkhachHang)
                    .HasName("PK__KhachHan__C87280B190044D87");

                entity.Property(e => e.SdtkhachHang).IsFixedLength();
            });

            modelBuilder.Entity<LichChieu>(entity =>
            {
                entity.HasKey(e => e.MaLichChieu)
                    .HasName("PK__LichChie__DC7401973F49771B");

                entity.Property(e => e.MaLichChieu).IsFixedLength();

                entity.Property(e => e.MaPhim).IsFixedLength();

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.LichChieus)
                    .HasForeignKey(d => d.MaPhim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichChieu__MaPhi__3D5E1FD2");

                entity.HasOne(d => d.MaPhongChieuNavigation)
                    .WithMany(p => p.LichChieus)
                    .HasForeignKey(d => d.MaPhongChieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichChieu__MaPho__3E52440B");
            });

            modelBuilder.Entity<Phim>(entity =>
            {
                entity.HasKey(e => e.MaPhim)
                    .HasName("PK__Phim__4AC03DE3AEA30281");

                entity.Property(e => e.MaPhim).IsFixedLength();

                entity.Property(e => e.MaDaoDien).IsFixedLength();

                entity.Property(e => e.MaDienVien).IsFixedLength();

                entity.Property(e => e.MaTheLoai).IsFixedLength();

                entity.Property(e => e.Rated).IsFixedLength();

                entity.HasOne(d => d.MaDaoDienNavigation)
                    .WithMany(p => p.Phims)
                    .HasForeignKey(d => d.MaDaoDien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phim__MaDaoDien__37A5467C");

                entity.HasOne(d => d.MaDienVienNavigation)
                    .WithMany(p => p.Phims)
                    .HasForeignKey(d => d.MaDienVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phim__MaDienVien__38996AB5");

                entity.HasOne(d => d.MaTheLoaiNavigation)
                    .WithMany(p => p.Phims)
                    .HasForeignKey(d => d.MaTheLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phim__MaTheLoai__36B12243");
            });

            modelBuilder.Entity<PhongChieu>(entity =>
            {
                entity.HasKey(e => e.MaPhongChieu)
                    .HasName("PK__PhongChi__121FC6E28F014E08");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__TheLoai__D73FF34A7AC5A304");

                entity.Property(e => e.MaTheLoai).IsFixedLength();
            });

            modelBuilder.Entity<TheThanhVien>(entity =>
            {
                entity.HasKey(e => e.SdtkhachHang)
                    .HasName("PK__TheThanh__C87280B114F00EF0");

                entity.Property(e => e.SdtkhachHang).IsFixedLength();

                entity.HasOne(d => d.SdtkhachHangNavigation)
                    .WithOne(p => p.TheThanhVien)
                    .HasForeignKey<TheThanhVien>(d => d.SdtkhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheThanhV__SDTKh__31EC6D26");
            });

            modelBuilder.Entity<ThongKe>(entity =>
            {
                entity.HasKey(e => e.MaThongKe)
                    .HasName("PK__ThongKe__60E521F4829A8D17");

                entity.Property(e => e.MaThongKe).IsFixedLength();
            });

            modelBuilder.Entity<Ve>(entity =>
            {
                entity.HasKey(e => e.MaVe)
                    .HasName("PK__Ve__2725100FC16CE094");

                entity.Property(e => e.MaVe).IsFixedLength();

                entity.Property(e => e.MaGhe).IsFixedLength();

                entity.Property(e => e.MaLichChieu).IsFixedLength();

                entity.Property(e => e.MaPhim).IsFixedLength();

                entity.HasOne(d => d.MaGheNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaGhe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ve__MaGhe__45F365D3");

                entity.HasOne(d => d.MaLichChieuNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaLichChieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ve__MaLichChieu__46E78A0C");

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaPhim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ve__MaPhim__440B1D61");

                entity.HasOne(d => d.MaPhongChieuNavigation)
                    .WithMany(p => p.Ves)
                    .HasForeignKey(d => d.MaPhongChieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ve__MaPhongChieu__44FF419A");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.MaVoucher)
                    .HasName("PK__Voucher__0AAC5B11AE7608F9");

                entity.Property(e => e.MaVoucher).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
