using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class DangKy
    {
        public string IdHocvien { get; set; }
        public string TenSukien { get; set; }

        public virtual Hocvien IdHocvienNavigation { get; set; }
        public virtual Sukien TenSukienNavigation { get; set; }
    }
}
