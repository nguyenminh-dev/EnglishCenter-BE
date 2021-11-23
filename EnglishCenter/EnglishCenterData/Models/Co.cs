using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Co
    {
        public string IdKhoahoc { get; set; }
        public string IdGiaotrinh { get; set; }

        public virtual Giaotrinh IdGiaotrinhNavigation { get; set; }
        public virtual Khoahoc IdKhoahocNavigation { get; set; }
    }
}
