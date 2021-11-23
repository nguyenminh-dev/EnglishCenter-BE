using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterApplication.HocVienModels
{
    public class HocVienDto
    {
        public string Id { get; set; }
        public string Ho { get; set; }
        public string Tenlot { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Email { get; set; }
    }
}
