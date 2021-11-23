using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Giohang
    {
        public string IdHocvien { get; set; }
        public string IdKhoahoc { get; set; }
        public DateTime NgayGio { get; set; }
        public string IdHoadon { get; set; }

        public virtual Hoadon IdHoadonNavigation { get; set; }
        public virtual Hocvien IdHocvienNavigation { get; set; }
        public virtual Khoahoc IdKhoahocNavigation { get; set; }
    }
}
