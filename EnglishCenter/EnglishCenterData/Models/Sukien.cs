using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Sukien
    {
        public Sukien()
        {
            DangKies = new HashSet<DangKy>();
            MoSuKiens = new HashSet<MoSuKien>();
        }

        public string Ten { get; set; }
        public DateTime? Thoigian { get; set; }
        public string Diachi { get; set; }

        public virtual ICollection<DangKy> DangKies { get; set; }
        public virtual ICollection<MoSuKien> MoSuKiens { get; set; }
    }
}
