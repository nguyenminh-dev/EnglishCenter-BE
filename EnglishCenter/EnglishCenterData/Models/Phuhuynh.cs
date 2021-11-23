using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Phuhuynh
    {
        public Phuhuynh()
        {
            PhanHois = new HashSet<PhanHoi>();
            SđtPhuhuynhs = new HashSet<SđtPhuhuynh>();
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public string Quanhe { get; set; }

        public virtual Hocvien IdNavigation { get; set; }
        public virtual ICollection<PhanHoi> PhanHois { get; set; }
        public virtual ICollection<SđtPhuhuynh> SđtPhuhuynhs { get; set; }
    }
}
