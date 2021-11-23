using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class DanhGium
    {
        public string IdHocvien { get; set; }
        public string IdKhoahoc { get; set; }
        public string Nhanxet { get; set; }
        public int? Sosao { get; set; }

        public virtual Hocvien IdHocvienNavigation { get; set; }
        public virtual Khoahoc IdKhoahocNavigation { get; set; }
    }
}
