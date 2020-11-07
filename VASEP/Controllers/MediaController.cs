using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.Media;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaBusinessLogic _businessLogic;

        public MediaController(IMediaBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("VideoShowGetList")]
        public async Task<VideoShowResponse> VideoGetList([FromQuery] VideoShowRequest request)
        {
            return await _businessLogic.VideoGetList(request);
        }

        [HttpGet("VideoDetail")]
        public async Task<VideoDetailResponse> VideoDetail([FromQuery] VideoDetailRequest request)
        {
            return await _businessLogic.VideoDetail(request);
        }
    }
}
