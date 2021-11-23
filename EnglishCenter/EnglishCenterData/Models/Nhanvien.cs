using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            LamViecs = new HashSet<LamViec>();
            LophocIdGiaovienNavigations = new HashSet<Lophoc>();
            LophocIdTrogiangNavigations = new HashSet<Lophoc>();
            SđtNhanviens = new HashSet<SđtNhanvien>();
        }

        public string Id { get; set; }
        public string Ho { get; set; }
        public string Tenlot { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Email { get; set; }
        public string Chungchi { get; set; }

        public virtual Chamsockhachhang Chamsockhachhang { get; set; }
        public virtual Giaovien Giaovien { get; set; }
        public virtual Quanly Quanly { get; set; }
        public virtual Trogiang Trogiang { get; set; }
        public virtual ICollection<LamViec> LamViecs { get; set; }
        public virtual ICollection<Lophoc> LophocIdGiaovienNavigations { get; set; }
        public virtual ICollection<Lophoc> LophocIdTrogiangNavigations { get; set; }
        public virtual ICollection<SđtNhanvien> SđtNhanviens { get; set; }
    }
}
