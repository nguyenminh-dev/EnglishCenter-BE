using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class SđtHocvien
    {
        public string IdHocvien { get; set; }
        public int Asđt { get; set; }

        public virtual Hocvien IdHocvienNavigation { get; set; }
    }
}
