using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.New;

namespace VASEP.Implement
{
    public class NewBusinessLogic : INewBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public NewBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<NewGetListByCategoryIdResponse> NewGetListByCategoryId(NewGetListByCategoryIdRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<NewObject> lstData = new List<NewObject>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("subtractIds", request.SubtractIds);
                    parameters.Add("CategoryId", request.CategoryId);
                    parameters.Add("portalId", request.PortalId);
                    parameters.Add("LanguageId", request.Language);
                    parameters.Add("PageIndex", request.PageIndex);
                    parameters.Add("PageSize", request.PageSize);
                    parameters.Add("isImage", request.IsImage);

                    await Task.Run(() =>
                        lstData = connection.Query<NewObject>("News_News_ShowSelect_Index", parameters, null, true, null, CommandType.StoredProcedure).AsList<NewObject>()
                    );
                    int totalRecords = lstData.Count > 0 ? lstData[0].TotalRecords : 0;
                    return new NewGetListByCategoryIdResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        LstData = lstData,
                        TotalRecords = totalRecords,
                    };
                }
            }
            catch (Exception ex)
            {
                return new NewGetListByCategoryIdResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
