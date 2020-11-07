using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.New;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private readonly INewBusinessLogic _businessLogic;

        public NewController(INewBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        [HttpGet("GetListNewByCategory")]
        public async Task<NewGetListByCategoryIdResponse> NewGetListByCategoryId([FromQuery] NewGetListByCategoryIdRequest request)
        {
            return await _businessLogic.NewGetListByCategoryId(request);
        }
    }
}
