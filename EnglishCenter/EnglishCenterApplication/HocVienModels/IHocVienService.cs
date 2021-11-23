using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterApplication.HocVienModels
{
    public interface IHocVienService
    {
        public Task<List<HocVienDto>> GetAll();
        public Task<HocVienDto> Get();
        public Task<List<SuKienDto>> GetSukien();
        /*public Task<string> DangKiSuKien();*/
        public Task<List<KhoaHocDto>> GetKhoaHoc();
    }
}
