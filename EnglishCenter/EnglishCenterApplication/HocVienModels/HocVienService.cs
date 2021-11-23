using EnglishCenterData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterApplication.HocVienModels
{
    public class HocVienService : IHocVienService
    {
        private readonly HETHONGCHAMSOCHOCVIENContext _dataContext;
        public HocVienService(HETHONGCHAMSOCHOCVIENContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<HocVienDto>> GetAll()
        {
            var respose = await _dataContext.Hocviens.Select(x => new HocVienDto()
            {
                Id = x.Id,
                Ho = x.Ho,
                Tenlot = x.Tenlot,
                Ten = x.Ten,
                Diachi = x.Diachi,
                Gioitinh = x.Gioitinh,
                Ngaysinh = x.Ngaysinh,
                Email = x.Email
                
            }).ToListAsync();
            return respose;
        }

        public async Task<HocVienDto> Get()
        {
            var respose = await _dataContext.Hocviens.Select(x => new HocVienDto()
            {
                Id = x.Id,
                Ho = x.Ho,
                Tenlot = x.Tenlot,
                Ten = x.Ten,
                Diachi = x.Diachi,
                Gioitinh = x.Gioitinh,
                Ngaysinh = x.Ngaysinh,
                Email = x.Email

            }).FirstOrDefaultAsync();
            return respose;
        }

        public async Task<List<SuKienDto>> GetSukien()
        {
            var respose = await _dataContext.Sukiens.Select(x => new SuKienDto()
            {
                Ten = x.Ten,
                Thoigian = x.Thoigian,
                Diachi = x.Diachi
            }).ToListAsync();
            return respose;
        }
        public async Task<List<KhoaHocDto>> GetKhoaHoc()
        {
            var respose = await _dataContext.Khoahocs.Select(x => new KhoaHocDto()
            {
                Id = x.Id,
                Ten = x.Ten,
                Khaigiang = x.Khaigiang,
                Ketthuc = x.Ketthuc,
                Dotuoi = x.Dotuoi,
                Review = x.Review
            }).ToListAsync();
            return respose;
        }
        /*public async Task<string> DangKiSuKien()
        {
            return "hello";
        }*/
    }
}
