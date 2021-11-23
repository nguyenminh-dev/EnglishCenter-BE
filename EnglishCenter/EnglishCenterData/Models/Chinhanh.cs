using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Chinhanh
    {
        public Chinhanh()
        {
            MoKhoaHocs = new HashSet<MoKhoaHoc>();
            MoSuKiens = new HashSet<MoSuKien>();
            Phongbans = new HashSet<Phongban>();
            SđtChinhanhs = new HashSet<SđtChinhanh>();
        }

        public string TenTrungtam { get; set; }
        public string Id { get; set; }
        public string Diachi { get; set; }

        public virtual Trungtam TenTrungtamNavigation { get; set; }
        public virtual ICollection<MoKhoaHoc> MoKhoaHocs { get; set; }
        public virtual ICollection<MoSuKien> MoSuKiens { get; set; }
        public virtual ICollection<Phongban> Phongbans { get; set; }
        public virtual ICollection<SđtChinhanh> SđtChinhanhs { get; set; }
    }
}
