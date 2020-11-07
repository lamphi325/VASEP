using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.Home;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeBusinessLogic _businessLogic;

        public HomeController(IHomeBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("NewDetail")]
        public async Task<NewDetailResponse> NewDetail([FromQuery] NewDetailRequest request)
        {
            return await _businessLogic.NewDetail(request);
        }

        [HttpGet("BaiMoiDanhMuc")]
        //[Authorize]
        public async Task<BaiMoiDanhMucResponse> BaiMoiDanhMuc([FromQuery] BaiMoiDanhMucRequest request)
        {
            return await _businessLogic.BaiMoiDanhMuc(request);
        }

        [HttpGet("BaiMoiNhat")]
        public async Task<BaiMoiNhatResponse> BaiMoiNhat([FromQuery] BaiMoiNhatRequest request)
        {
            return await _businessLogic.BaiMoiNhat(request);
        }
    }
}
