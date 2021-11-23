using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Chamsockhachhang
    {
        public Chamsockhachhang()
        {
            PhanHois = new HashSet<PhanHoi>();
        }

        public string Id { get; set; }
        public string Bangcap { get; set; }

        public virtual Nhanvien IdNavigation { get; set; }
        public virtual ICollection<PhanHoi> PhanHois { get; set; }
    }
}
