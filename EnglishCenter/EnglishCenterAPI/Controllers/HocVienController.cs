using EnglishCenterApplication.HocVienModels;
using EnglishCenterData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishCenterAPI.Controllers
{
    [Route("api/HocVien")]
    [ApiController]
    public class HocVienController : ControllerBase
    {
        private readonly IHocVienService _hocVienService;
        public HocVienController(IHocVienService hocVienService)
        {
            _hocVienService = hocVienService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _hocVienService.Get());
        }

        [HttpGet]
        [Route("getsukien")]
        public async Task<IActionResult> GetSuKien()
        {
            return Ok(await _hocVienService.GetSukien());
        }

        [HttpGet]
        [Route("getkhoahoc")]
        public async Task<IActionResult> GetKhoaHoc()
        {
            return Ok(await _hocVienService.GetKhoaHoc());
        }

    }
}
