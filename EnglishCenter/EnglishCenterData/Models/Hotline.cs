using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Hotline
    {
        public string TenTrungtam { get; set; }
        public int Ahotline { get; set; }

        public virtual Trungtam TenTrungtamNavigation { get; set; }
    }
}
