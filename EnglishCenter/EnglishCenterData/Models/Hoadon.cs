using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Giohangs = new HashSet<Giohang>();
        }

        public string Id { get; set; }
        public DateTime? NgayGio { get; set; }
        public string Ten { get; set; }

        public virtual Phuongthucthanhtoan TenNavigation { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
    }
}
