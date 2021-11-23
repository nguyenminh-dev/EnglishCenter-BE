using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class ChiDinh
    {
        public string IdGiaotrinh { get; set; }
        public string IdQuanly { get; set; }

        public virtual Giaotrinh IdGiaotrinhNavigation { get; set; }
        public virtual Quanly IdQuanlyNavigation { get; set; }
    }
}
