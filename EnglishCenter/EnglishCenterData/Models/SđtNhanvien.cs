using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class SđtNhanvien
    {
        public string IdNhanvien { get; set; }
        public int Asđt { get; set; }

        public virtual Nhanvien IdNhanvienNavigation { get; set; }
    }
}
