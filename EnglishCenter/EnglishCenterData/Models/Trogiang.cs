using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Trogiang
    {
        public string Id { get; set; }
        public string Trinhdohocvan { get; set; }

        public virtual Nhanvien IdNavigation { get; set; }
    }
}
