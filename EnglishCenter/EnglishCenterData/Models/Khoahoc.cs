using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Khoahoc
    {
        public Khoahoc()
        {
            ChiaRas = new HashSet<ChiaRa>();
            Cos = new HashSet<Co>();
            DanhGia = new HashSet<DanhGium>();
            Giohangs = new HashSet<Giohang>();
            MoKhoaHocs = new HashSet<MoKhoaHoc>();
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public DateTime? Khaigiang { get; set; }
        public DateTime? Ketthuc { get; set; }
        public int? Dotuoi { get; set; }
        public string Review { get; set; }

        public virtual ICollection<ChiaRa> ChiaRas { get; set; }
        public virtual ICollection<Co> Cos { get; set; }
        public virtual ICollection<DanhGium> DanhGia { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
        public virtual ICollection<MoKhoaHoc> MoKhoaHocs { get; set; }
    }
}
