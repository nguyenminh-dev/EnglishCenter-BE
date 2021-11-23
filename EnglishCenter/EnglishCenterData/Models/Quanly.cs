using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Quanly
    {
        public Quanly()
        {
            ChiDinhs = new HashSet<ChiDinh>();
            ChiaRas = new HashSet<ChiaRa>();
        }

        public string Id { get; set; }
        public string Bangcap { get; set; }
        public int? Sonamkinhnghiem { get; set; }

        public virtual Nhanvien IdNavigation { get; set; }
        public virtual ICollection<ChiDinh> ChiDinhs { get; set; }
        public virtual ICollection<ChiaRa> ChiaRas { get; set; }
    }
}
