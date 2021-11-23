using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class HETHONGCHAMSOCHOCVIENContext : DbContext
    {
        public HETHONGCHAMSOCHOCVIENContext()
        {
        }

        public HETHONGCHAMSOCHOCVIENContext(DbContextOptions<HETHONGCHAMSOCHOCVIENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Baikiemtra> Baikiemtras { get; set; }
        public virtual DbSet<Chamsockhachhang> Chamsockhachhangs { get; set; }
        public virtual DbSet<ChiDinh> ChiDinhs { get; set; }
        public virtual DbSet<ChiaRa> ChiaRas { get; set; }
        public virtual DbSet<Chinhanh> Chinhanhs { get; set; }
        public virtual DbSet<Co> Cos { get; set; }
        public virtual DbSet<DangKy> DangKies { get; set; }
        public virtual DbSet<DanhGium> DanhGia { get; set; }
        public virtual DbSet<Giaotrinh> Giaotrinhs { get; set; }
        public virtual DbSet<Giaovien> Giaoviens { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Hocvien> Hocviens { get; set; }
        public virtual DbSet<Hotline> Hotlines { get; set; }
        public virtual DbSet<Khoahoc> Khoahocs { get; set; }
        public virtual DbSet<LamBaiKiemTra> LamBaiKiemTras { get; set; }
        public virtual DbSet<LamViec> LamViecs { get; set; }
        public virtual DbSet<Lophoc> Lophocs { get; set; }
        public virtual DbSet<MoKhoaHoc> MoKhoaHocs { get; set; }
        public virtual DbSet<MoSuKien> MoSuKiens { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<PhanHoi> PhanHois { get; set; }
        public virtual DbSet<Phongban> Phongbans { get; set; }
        public virtual DbSet<Phuhuynh> Phuhuynhs { get; set; }
        public virtual DbSet<Phuongthucthanhtoan> Phuongthucthanhtoans { get; set; }
        public virtual DbSet<Quanly> Quanlies { get; set; }
        public virtual DbSet<Sukien> Sukiens { get; set; }
        public virtual DbSet<SđtChinhanh> SđtChinhanhs { get; set; }
        public virtual DbSet<SđtHocvien> SđtHocviens { get; set; }
        public virtual DbSet<SđtNhanvien> SđtNhanviens { get; set; }
        public virtual DbSet<SđtPhuhuynh> SđtPhuhuynhs { get; set; }
        public virtual DbSet<ThamGium> ThamGia { get; set; }
        public virtual DbSet<Trogiang> Trogiangs { get; set; }
        public virtual DbSet<Trungtam> Trungtams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HETHONGCHAMSOCHOCVIEN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Baikiemtra>(entity =>
            {
                entity.ToTable("BAIKIEMTRA");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.IdGiaovien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Giaovien")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdGiaovienNavigation)
                    .WithMany(p => p.Baikiemtras)
                    .HasForeignKey(d => d.IdGiaovien)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_baikiemtra_giaovien_ID");
            });

            modelBuilder.Entity<Chamsockhachhang>(entity =>
            {
                entity.ToTable("CHAMSOCKHACHHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Bangcap).HasMaxLength(100);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Chamsockhachhang)
                    .HasForeignKey<Chamsockhachhang>(d => d.Id)
                    .HasConstraintName("fk_cskh_nhanvien_ID");
            });

            modelBuilder.Entity<ChiDinh>(entity =>
            {
                entity.HasKey(e => new { e.IdGiaotrinh, e.IdQuanly })
                    .HasName("PK__chi_dinh__55D7935D51FA3411");

                entity.ToTable("chi_dinh");

                entity.Property(e => e.IdGiaotrinh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Giaotrinh")
                    .IsFixedLength(true);

                entity.Property(e => e.IdQuanly)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Quanly")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdGiaotrinhNavigation)
                    .WithMany(p => p.ChiDinhs)
                    .HasForeignKey(d => d.IdGiaotrinh)
                    .HasConstraintName("fk_chidinh_giaotrinh_ID");

                entity.HasOne(d => d.IdQuanlyNavigation)
                    .WithMany(p => p.ChiDinhs)
                    .HasForeignKey(d => d.IdQuanly)
                    .HasConstraintName("fk_chidinh_quanly_ID");
            });

            modelBuilder.Entity<ChiaRa>(entity =>
            {
                entity.HasKey(e => new { e.IdKhoahoc, e.TenLophoc, e.IdQuanly })
                    .HasName("PK__chia_ra__52A3526286A01998");

                entity.ToTable("chia_ra");

                entity.Property(e => e.IdKhoahoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Khoahoc")
                    .IsFixedLength(true);

                entity.Property(e => e.TenLophoc)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Lophoc");

                entity.Property(e => e.IdQuanly)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Quanly")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdKhoahocNavigation)
                    .WithMany(p => p.ChiaRas)
                    .HasForeignKey(d => d.IdKhoahoc)
                    .HasConstraintName("fk_chiara_khoahoc_ID");

                entity.HasOne(d => d.IdQuanlyNavigation)
                    .WithMany(p => p.ChiaRas)
                    .HasForeignKey(d => d.IdQuanly)
                    .HasConstraintName("fk_chiara_quanly_ID");

                entity.HasOne(d => d.TenLophocNavigation)
                    .WithMany(p => p.ChiaRas)
                    .HasForeignKey(d => d.TenLophoc)
                    .HasConstraintName("fk_chiara_lophoc_ten");
            });

            modelBuilder.Entity<Chinhanh>(entity =>
            {
                entity.HasKey(e => new { e.TenTrungtam, e.Id })
                    .HasName("PK__CHINHANH__B7C4282F67708546");

                entity.ToTable("CHINHANH");

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.HasOne(d => d.TenTrungtamNavigation)
                    .WithMany(p => p.Chinhanhs)
                    .HasForeignKey(d => d.TenTrungtam)
                    .HasConstraintName("fk_chinhanh_trungtam_ten");
            });

            modelBuilder.Entity<Co>(entity =>
            {
                entity.HasKey(e => new { e.IdKhoahoc, e.IdGiaotrinh })
                    .HasName("PK__co__4C6C552166ECFA4E");

                entity.ToTable("co");

                entity.Property(e => e.IdKhoahoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Khoahoc")
                    .IsFixedLength(true);

                entity.Property(e => e.IdGiaotrinh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Giaotrinh")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdGiaotrinhNavigation)
                    .WithMany(p => p.Cos)
                    .HasForeignKey(d => d.IdGiaotrinh)
                    .HasConstraintName("fk_co_giaotrinh_ID");

                entity.HasOne(d => d.IdKhoahocNavigation)
                    .WithMany(p => p.Cos)
                    .HasForeignKey(d => d.IdKhoahoc)
                    .HasConstraintName("fk_co_khoahoc_ID");
            });

            modelBuilder.Entity<DangKy>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.TenSukien })
                    .HasName("PK__dang_ky__CCAAB4A2A63B7D0C");

                entity.ToTable("dang_ky");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSukien)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Sukien");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.DangKies)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_dangki_hocvien_ID");

                entity.HasOne(d => d.TenSukienNavigation)
                    .WithMany(p => p.DangKies)
                    .HasForeignKey(d => d.TenSukien)
                    .HasConstraintName("fk_dangki_sukien_Ten");
            });

            modelBuilder.Entity<DanhGium>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.IdKhoahoc })
                    .HasName("PK__danh_gia__0313859624BE5DCF");

                entity.ToTable("danh_gia");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.IdKhoahoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Khoahoc")
                    .IsFixedLength(true);

                entity.Property(e => e.Nhanxet).HasMaxLength(200);

                entity.Property(e => e.Sosao).HasColumnName("sosao");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.DanhGia)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_danhgia_hocvien_ID");

                entity.HasOne(d => d.IdKhoahocNavigation)
                    .WithMany(p => p.DanhGia)
                    .HasForeignKey(d => d.IdKhoahoc)
                    .HasConstraintName("fk_danhgia_khoahoc_ID");
            });

            modelBuilder.Entity<Giaotrinh>(entity =>
            {
                entity.ToTable("GIAOTRINH");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Nxb)
                    .HasColumnType("date")
                    .HasColumnName("NXB");

                entity.Property(e => e.Tacgia).HasMaxLength(100);

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<Giaovien>(entity =>
            {
                entity.ToTable("GIAOVIEN");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Bangcap).HasMaxLength(100);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Giaovien)
                    .HasForeignKey<Giaovien>(d => d.Id)
                    .HasConstraintName("fk_giaovien_nhanvien_ID");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.IdKhoahoc, e.NgayGio })
                    .HasName("PK__GIOHANG__B7E57F5D8D0A6803");

                entity.ToTable("GIOHANG");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.IdKhoahoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Khoahoc")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayGio)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_gio");

                entity.Property(e => e.IdHoadon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hoadon")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdHoadonNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.IdHoadon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_giohang_hoadon_ID");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_giohang_hocvien_ID");

                entity.HasOne(d => d.IdKhoahocNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.IdKhoahoc)
                    .HasConstraintName("fk_giohang_khoahoc_ID");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.ToTable("HOADON");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayGio)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_gio");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.HasOne(d => d.TenNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Ten)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_hoadon_pptt_ten");
            });

            modelBuilder.Entity<Hocvien>(entity =>
            {
                entity.ToTable("HOCVIEN");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ho).HasMaxLength(20);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Ten).HasMaxLength(20);

                entity.Property(e => e.Tenlot).HasMaxLength(50);
            });

            modelBuilder.Entity<Hotline>(entity =>
            {
                entity.HasKey(e => new { e.TenTrungtam, e.Ahotline })
                    .HasName("PK__hotline__03279A3500F512AC");

                entity.ToTable("hotline");

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.HasOne(d => d.TenTrungtamNavigation)
                    .WithMany(p => p.Hotlines)
                    .HasForeignKey(d => d.TenTrungtam)
                    .HasConstraintName("fk_hotline_trungtam_ten");
            });

            modelBuilder.Entity<Khoahoc>(entity =>
            {
                entity.ToTable("KHOAHOC");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Ketthuc)
                    .HasColumnType("date")
                    .HasColumnName("ketthuc");

                entity.Property(e => e.Khaigiang)
                    .HasColumnType("date")
                    .HasColumnName("khaigiang");

                entity.Property(e => e.Review)
                    .HasMaxLength(200)
                    .HasColumnName("review");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            modelBuilder.Entity<LamBaiKiemTra>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.IdBaikiemtra })
                    .HasName("PK__lam_bai___CA14243C0AD79222");

                entity.ToTable("lam_bai_kiem_tra");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.IdBaikiemtra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Baikiemtra")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdBaikiemtraNavigation)
                    .WithMany(p => p.LamBaiKiemTras)
                    .HasForeignKey(d => d.IdBaikiemtra)
                    .HasConstraintName("fk_lamktra_baiktra_ID");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.LamBaiKiemTras)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_lamktra_hocvien_ID");
            });

            modelBuilder.Entity<LamViec>(entity =>
            {
                entity.HasKey(e => new { e.IdPhongban, e.IdNhanvien })
                    .HasName("PK__lam_viec__5035681852875894");

                entity.ToTable("lam_viec");

                entity.Property(e => e.IdPhongban)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Phongban")
                    .IsFixedLength(true);

                entity.Property(e => e.IdNhanvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Nhanvien")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdNhanvienNavigation)
                    .WithMany(p => p.LamViecs)
                    .HasForeignKey(d => d.IdNhanvien)
                    .HasConstraintName("fk_lamviec_nhanvien_ID");

                entity.HasOne(d => d.IdPhongbanNavigation)
                    .WithMany(p => p.LamViecs)
                    .HasForeignKey(d => d.IdPhongban)
                    .HasConstraintName("fk_lamviec_phongban_ID");
            });

            modelBuilder.Entity<Lophoc>(entity =>
            {
                entity.HasKey(e => e.Ten)
                    .HasName("PK__LOPHOC__C451FA82FB1EAC03");

                entity.ToTable("LOPHOC");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.IdGiaovien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Giaovien")
                    .IsFixedLength(true);

                entity.Property(e => e.IdTrogiang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Trogiang")
                    .IsFixedLength(true);

                entity.Property(e => e.Lichhoc).HasMaxLength(100);

                entity.Property(e => e.Phong).HasMaxLength(50);

                entity.HasOne(d => d.IdGiaovienNavigation)
                    .WithMany(p => p.LophocIdGiaovienNavigations)
                    .HasForeignKey(d => d.IdGiaovien)
                    .HasConstraintName("fk_lophoc_giaovien_ID");

                entity.HasOne(d => d.IdTrogiangNavigation)
                    .WithMany(p => p.LophocIdTrogiangNavigations)
                    .HasForeignKey(d => d.IdTrogiang)
                    .HasConstraintName("fk_lophoc_trogiang_ID");
            });

            modelBuilder.Entity<MoKhoaHoc>(entity =>
            {
                entity.HasKey(e => new { e.IdKhoahoc, e.TenTrungtam, e.IdChinhanh })
                    .HasName("PK__mo_khoa___8230E8082B91D761");

                entity.ToTable("mo_khoa_hoc");

                entity.Property(e => e.IdKhoahoc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Khoahoc")
                    .IsFixedLength(true);

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.Property(e => e.IdChinhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Chinhanh")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdKhoahocNavigation)
                    .WithMany(p => p.MoKhoaHocs)
                    .HasForeignKey(d => d.IdKhoahoc)
                    .HasConstraintName("fk_mokhoahoc_khoahoc_ID");

                entity.HasOne(d => d.Chinhanh)
                    .WithMany(p => p.MoKhoaHocs)
                    .HasForeignKey(d => new { d.TenTrungtam, d.IdChinhanh })
                    .HasConstraintName("fk_mokhoahoc_chinhnhanh");
            });

            modelBuilder.Entity<MoSuKien>(entity =>
            {
                entity.HasKey(e => new { e.TenSukien, e.TenTrungtam, e.IdChinhanh })
                    .HasName("PK__mo_su_ki__79A3FB44A5AD9791");

                entity.ToTable("mo_su_kien");

                entity.Property(e => e.TenSukien)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Sukien");

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.Property(e => e.IdChinhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Chinhanh")
                    .IsFixedLength(true);

                entity.HasOne(d => d.TenSukienNavigation)
                    .WithMany(p => p.MoSuKiens)
                    .HasForeignKey(d => d.TenSukien)
                    .HasConstraintName("fk_mosukien_sukien_ten");

                entity.HasOne(d => d.Chinhanh)
                    .WithMany(p => p.MoSuKiens)
                    .HasForeignKey(d => new { d.TenTrungtam, d.IdChinhanh })
                    .HasConstraintName("fk_mosukien_chinhanh");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Chungchi).HasMaxLength(100);

                entity.Property(e => e.Diachi).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ho).HasMaxLength(20);

                entity.Property(e => e.Ngaysinh).HasColumnType("date");

                entity.Property(e => e.Ten).HasMaxLength(20);

                entity.Property(e => e.Tenlot).HasMaxLength(50);
            });

            modelBuilder.Entity<PhanHoi>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.IdChamsockhachhang })
                    .HasName("PK__phan_hoi__149BC9FDB727FF93");

                entity.ToTable("phan_hoi");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.IdChamsockhachhang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Chamsockhachhang")
                    .IsFixedLength(true);

                entity.Property(e => e.TenPhuhuynh)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Phuhuynh");

                entity.HasOne(d => d.IdChamsockhachhangNavigation)
                    .WithMany(p => p.PhanHois)
                    .HasForeignKey(d => d.IdChamsockhachhang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phanhoi_cskh_ID");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.PhanHois)
                    .HasForeignKey(d => d.IdHocvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phanhoi_hocvien_ID");

                entity.HasOne(d => d.Phuhuynh)
                    .WithMany(p => p.PhanHois)
                    .HasForeignKey(d => new { d.IdHocvien, d.TenPhuhuynh })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_phanhoi_phuhuynh");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.ToTable("PHONGBAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.IdChinhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Chinhanh")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.HasOne(d => d.Chinhanh)
                    .WithMany(p => p.Phongbans)
                    .HasForeignKey(d => new { d.TenTrungtam, d.IdChinhanh })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_phongban_chinhanh");
            });

            modelBuilder.Entity<Phuhuynh>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Ten })
                    .HasName("PK__PHUHUYNH__0E51F38F79B98719");

                entity.ToTable("PHUHUYNH");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.Property(e => e.Quanhe).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Phuhuynhs)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("fk_phuhuynh_hocvien_ID");
            });

            modelBuilder.Entity<Phuongthucthanhtoan>(entity =>
            {
                entity.HasKey(e => e.Ten)
                    .HasName("PK__PHUONGTH__C451FA828F0236E8");

                entity.ToTable("PHUONGTHUCTHANHTOAN");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.Mota).HasMaxLength(100);
            });

            modelBuilder.Entity<Quanly>(entity =>
            {
                entity.ToTable("QUANLY");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Bangcap).HasMaxLength(100);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Quanly)
                    .HasForeignKey<Quanly>(d => d.Id)
                    .HasConstraintName("fk_quanly_nhanvien_ID");
            });

            modelBuilder.Entity<Sukien>(entity =>
            {
                entity.HasKey(e => e.Ten)
                    .HasName("PK__SUKIEN__C451FA8276226FEC");

                entity.ToTable("SUKIEN");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.Diachi).HasMaxLength(200);

                entity.Property(e => e.Thoigian).HasColumnType("datetime");
            });

            modelBuilder.Entity<SđtChinhanh>(entity =>
            {
                entity.HasKey(e => new { e.TenTrungtam, e.IdChinhanh, e.Asđt })
                    .HasName("PK__SĐT_Chin__7B683B753E0A97BD");

                entity.ToTable("SĐT_Chinhanh");

                entity.Property(e => e.TenTrungtam)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Trungtam");

                entity.Property(e => e.IdChinhanh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Chinhanh")
                    .IsFixedLength(true);

                entity.Property(e => e.Asđt).HasColumnName("ASĐT");

                entity.HasOne(d => d.Chinhanh)
                    .WithMany(p => p.SđtChinhanhs)
                    .HasForeignKey(d => new { d.TenTrungtam, d.IdChinhanh })
                    .HasConstraintName("fk_sdt_chinhanh");
            });

            modelBuilder.Entity<SđtHocvien>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.Asđt })
                    .HasName("PK__SĐT_Hocv__331F7948A2ABEC52");

                entity.ToTable("SĐT_Hocvien");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.Asđt).HasColumnName("ASĐT");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.SđtHocviens)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_sdt_hocvien_ID");
            });

            modelBuilder.Entity<SđtNhanvien>(entity =>
            {
                entity.HasKey(e => new { e.IdNhanvien, e.Asđt })
                    .HasName("PK__SĐT_Nhan__20E8A0C94FA04AB2");

                entity.ToTable("SĐT_Nhanvien");

                entity.Property(e => e.IdNhanvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Nhanvien")
                    .IsFixedLength(true);

                entity.Property(e => e.Asđt).HasColumnName("ASĐT");

                entity.HasOne(d => d.IdNhanvienNavigation)
                    .WithMany(p => p.SđtNhanviens)
                    .HasForeignKey(d => d.IdNhanvien)
                    .HasConstraintName("fk_sdt_nhanvien_ID");
            });

            modelBuilder.Entity<SđtPhuhuynh>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.TenPhuhuynh, e.Asđt })
                    .HasName("PK__SĐT_Phuh__05AA8077F78B2927");

                entity.ToTable("SĐT_Phuhuynh");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.TenPhuhuynh)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Phuhuynh");

                entity.Property(e => e.Asđt).HasColumnName("ASĐT");

                entity.HasOne(d => d.Phuhuynh)
                    .WithMany(p => p.SđtPhuhuynhs)
                    .HasForeignKey(d => new { d.IdHocvien, d.TenPhuhuynh })
                    .HasConstraintName("fk_sdt_phuhuynh_ID");
            });

            modelBuilder.Entity<ThamGium>(entity =>
            {
                entity.HasKey(e => new { e.IdHocvien, e.TenLophoc })
                    .HasName("PK__tham_gia__4C53D0B692E04326");

                entity.ToTable("tham_gia");

                entity.Property(e => e.IdHocvien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID_Hocvien")
                    .IsFixedLength(true);

                entity.Property(e => e.TenLophoc)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Lophoc");

                entity.HasOne(d => d.IdHocvienNavigation)
                    .WithMany(p => p.ThamGia)
                    .HasForeignKey(d => d.IdHocvien)
                    .HasConstraintName("fk_thamgia_hocvien_ID");

                entity.HasOne(d => d.TenLophocNavigation)
                    .WithMany(p => p.ThamGia)
                    .HasForeignKey(d => d.TenLophoc)
                    .HasConstraintName("fk_thamgia_lophoc_Ten");
            });

            modelBuilder.Entity<Trogiang>(entity =>
            {
                entity.ToTable("TROGIANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Trinhdohocvan).HasMaxLength(100);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Trogiang)
                    .HasForeignKey<Trogiang>(d => d.Id)
                    .HasConstraintName("fk_trogiang_nhanvien_ID");
            });

            modelBuilder.Entity<Trungtam>(entity =>
            {
                entity.HasKey(e => e.Ten)
                    .HasName("PK__TRUNGTAM__C451FA82D6C063A9");

                entity.ToTable("TRUNGTAM");

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
