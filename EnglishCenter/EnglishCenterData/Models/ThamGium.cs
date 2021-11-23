using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class ThamGium
    {
        public string IdHocvien { get; set; }
        public string TenLophoc { get; set; }

        public virtual Hocvien IdHocvienNavigation { get; set; }
        public virtual Lophoc TenLophocNavigation { get; set; }
    }
}
