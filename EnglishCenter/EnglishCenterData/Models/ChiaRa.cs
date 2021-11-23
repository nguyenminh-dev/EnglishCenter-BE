using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class ChiaRa
    {
        public string IdKhoahoc { get; set; }
        public string TenLophoc { get; set; }
        public string IdQuanly { get; set; }

        public virtual Khoahoc IdKhoahocNavigation { get; set; }
        public virtual Quanly IdQuanlyNavigation { get; set; }
        public virtual Lophoc TenLophocNavigation { get; set; }
    }
}
