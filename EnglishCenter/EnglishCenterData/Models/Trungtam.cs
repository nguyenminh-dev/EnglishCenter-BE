using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Trungtam
    {
        public Trungtam()
        {
            Chinhanhs = new HashSet<Chinhanh>();
            Hotlines = new HashSet<Hotline>();
        }

        public string Ten { get; set; }

        public virtual ICollection<Chinhanh> Chinhanhs { get; set; }
        public virtual ICollection<Hotline> Hotlines { get; set; }
    }
}
