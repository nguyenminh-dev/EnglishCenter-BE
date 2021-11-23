using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class SđtPhuhuynh
    {
        public string IdHocvien { get; set; }
        public string TenPhuhuynh { get; set; }
        public int Asđt { get; set; }

        public virtual Phuhuynh Phuhuynh { get; set; }
    }
}
