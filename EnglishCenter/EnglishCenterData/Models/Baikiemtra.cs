using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Baikiemtra
    {
        public Baikiemtra()
        {
            LamBaiKiemTras = new HashSet<LamBaiKiemTra>();
        }

        public string Id { get; set; }
        public string IdGiaovien { get; set; }

        public virtual Giaovien IdGiaovienNavigation { get; set; }
        public virtual ICollection<LamBaiKiemTra> LamBaiKiemTras { get; set; }
    }
}
