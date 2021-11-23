using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class SđtChinhanh
    {
        public string TenTrungtam { get; set; }
        public string IdChinhanh { get; set; }
        public int Asđt { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }
    }
}
