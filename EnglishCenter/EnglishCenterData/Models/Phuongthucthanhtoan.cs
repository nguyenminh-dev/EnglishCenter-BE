using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Phuongthucthanhtoan
    {
        public Phuongthucthanhtoan()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string Ten { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
