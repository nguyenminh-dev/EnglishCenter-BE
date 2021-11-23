using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class MoKhoaHoc
    {
        public string IdKhoahoc { get; set; }
        public string TenTrungtam { get; set; }
        public string IdChinhanh { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }
        public virtual Khoahoc IdKhoahocNavigation { get; set; }
    }
}
