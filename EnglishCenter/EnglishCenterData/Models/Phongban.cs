using System;
using System.Collections.Generic;

#nullable disable

namespace EnglishCenterData.Models
{
    public partial class Phongban
    {
        public Phongban()
        {
            LamViecs = new HashSet<LamViec>();
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public string TenTrungtam { get; set; }
        public string IdChinhanh { get; set; }

        public virtual Chinhanh Chinhanh { get; set; }
        public virtual ICollection<LamViec> LamViecs { get; set; }
    }
}
