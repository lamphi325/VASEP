using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.Common;
using VASEP.Interfaces.Models.Document;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentBusinessLogic _businessLogic;

        public DocumentController(IDocumentBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("GetList")]
        public async Task<DocumentGetListResponse> GetList([FromQuery] DocumentGetListRequest request)
        {
            return await _businessLogic.GetList(request);
        }

        [HttpGet("DocumentDetail")]
        public async Task<DocumentDetailResponse> DocumentDetail([FromQuery] DocumentDetailRequest request)
        {
            return await _businessLogic.DocumentDetail(request);
        }

        [HttpPut("UpdateViewCount")]
        public async Task<UpdateViewCountResponse> UpdateViewCount([FromBody] GetByIdRequest request)
        {
            return await _businessLogic.UpdateViewCount(request);
        }
    }
}
