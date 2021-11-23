using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Giaovien
    {
        public Giaovien()
        {
            Baikiemtras = new HashSet<Baikiemtra>();
        }

        public string Id { get; set; }
        public string Bangcap { get; set; }

        public virtual Nhanvien IdNavigation { get; set; }
        public virtual ICollection<Baikiemtra> Baikiemtras { get; set; }
    }
}
