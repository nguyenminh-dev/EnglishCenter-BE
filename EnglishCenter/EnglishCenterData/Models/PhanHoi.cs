using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class PhanHoi
    {
        public string IdHocvien { get; set; }
        public string IdChamsockhachhang { get; set; }
        public string TenPhuhuynh { get; set; }

        public virtual Chamsockhachhang IdChamsockhachhangNavigation { get; set; }
        public virtual Hocvien IdHocvienNavigation { get; set; }
        public virtual Phuhuynh Phuhuynh { get; set; }
    }
}
