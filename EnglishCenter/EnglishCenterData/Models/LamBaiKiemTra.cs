using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class LamBaiKiemTra
    {
        public string IdHocvien { get; set; }
        public string IdBaikiemtra { get; set; }
        public int? Diem { get; set; }

        public virtual Baikiemtra IdBaikiemtraNavigation { get; set; }
        public virtual Hocvien IdHocvienNavigation { get; set; }
    }
}
