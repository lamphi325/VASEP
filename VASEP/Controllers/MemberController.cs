using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.Common;
using VASEP.Interfaces.Models.Member;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberBusinessLogic _businessLogic;

        public MemberController(IMemberBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("GetList")]
        public async Task<MemberGetListResponse> GetList([FromQuery] MemberGetListRequest request)
        {
            return await _businessLogic.GetList(request);
        }

        [HttpGet("GetById")]
        public async Task<MemberGetByIdResponse> GetById([FromQuery] GetByIdRequest request)
        {
            return await _businessLogic.GetById(request);
        }
    }
}
