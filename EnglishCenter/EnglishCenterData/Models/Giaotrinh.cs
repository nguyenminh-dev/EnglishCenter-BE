using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Giaotrinh
    {
        public Giaotrinh()
        {
            ChiDinhs = new HashSet<ChiDinh>();
            Cos = new HashSet<Co>();
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public DateTime? Nxb { get; set; }
        public string Tacgia { get; set; }

        public virtual ICollection<ChiDinh> ChiDinhs { get; set; }
        public virtual ICollection<Co> Cos { get; set; }
    }
}
