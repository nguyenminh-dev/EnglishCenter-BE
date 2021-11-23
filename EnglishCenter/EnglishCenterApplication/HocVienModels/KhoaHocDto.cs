using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterApplication.HocVienModels
{
    public class KhoaHocDto
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public DateTime? Khaigiang { get; set; }
        public DateTime? Ketthuc { get; set; }
        public int? Dotuoi { get; set; }
        public string Review { get; set; }
    }
}
