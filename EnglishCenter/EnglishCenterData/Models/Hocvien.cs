using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Hocvien
    {
        public Hocvien()
        {
            DangKies = new HashSet<DangKy>();
            DanhGia = new HashSet<DanhGium>();
            Giohangs = new HashSet<Giohang>();
            LamBaiKiemTras = new HashSet<LamBaiKiemTra>();
            PhanHois = new HashSet<PhanHoi>();
            Phuhuynhs = new HashSet<Phuhuynh>();
            SđtHocviens = new HashSet<SđtHocvien>();
            ThamGia = new HashSet<ThamGium>();
        }

        public string Id { get; set; }
        public string Ho { get; set; }
        public string Tenlot { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DangKy> DangKies { get; set; }
        public virtual ICollection<DanhGium> DanhGia { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
        public virtual ICollection<LamBaiKiemTra> LamBaiKiemTras { get; set; }
        public virtual ICollection<PhanHoi> PhanHois { get; set; }
        public virtual ICollection<Phuhuynh> Phuhuynhs { get; set; }
        public virtual ICollection<SđtHocvien> SđtHocviens { get; set; }
        public virtual ICollection<ThamGium> ThamGia { get; set; }
    }
}
