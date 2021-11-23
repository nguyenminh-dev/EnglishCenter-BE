using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class MoSuKien
    {
        public string TenSukien { get; set; }
        public string TenTrungtam { get; set; }
        public string IdChinhanh { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }
        public virtual Sukien TenSukienNavigation { get; set; }
    }
}
