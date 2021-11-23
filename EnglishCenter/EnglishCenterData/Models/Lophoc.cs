using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Lophoc
    {
        public Lophoc()
        {
            ChiaRas = new HashSet<ChiaRa>();
            ThamGia = new HashSet<ThamGium>();
        }

        public string Ten { get; set; }
        public string Phong { get; set; }
        public string Lichhoc { get; set; }
        public string IdGiaovien { get; set; }
        public string IdTrogiang { get; set; }

        public virtual Nhanvien IdGiaovienNavigation { get; set; }
        public virtual Nhanvien IdTrogiangNavigation { get; set; }
        public virtual ICollection<ChiaRa> ChiaRas { get; set; }
        public virtual ICollection<ThamGium> ThamGia { get; set; }
    }
}
