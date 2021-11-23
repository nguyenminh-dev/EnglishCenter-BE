using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class LamViec
    {
        public string IdPhongban { get; set; }
        public string IdNhanvien { get; set; }

        public virtual Nhanvien IdNhanvienNavigation { get; set; }
        public virtual Phongban IdPhongbanNavigation { get; set; }
    }
}
