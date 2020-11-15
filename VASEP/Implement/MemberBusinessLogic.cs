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
using VASEP.Interfaces.Models.Common;
using VASEP.Interfaces.Models.Member;

namespace VASEP.Implement
{
    public class MemberBusinessLogic : IMemberBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public MemberBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<MemberGetByIdResponse> GetById(GetByIdRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    MemberGetById member = new MemberGetById();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Id", request.Id);

                    await Task.Run(() =>
                        member = connection.Query<MemberGetById>("MI_Get", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );

                    return new MemberGetByIdResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        Member = member,
                    };
                }
            }
            catch (Exception ex)
            {
                return new MemberGetByIdResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<MemberGetListResponse> GetList(MemberGetListRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<MemberGetList> lstData = new List<MemberGetList>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Keyword", request.Keyword);
                    parameters.Add("@SearchType", request.SearchType);
                    parameters.Add("@PageIndex", request.PageIndex);
                    parameters.Add("@PageSize", request.PageSize);
                    parameters.Add("@TotalRecords", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    await Task.Run(() =>
                        lstData = connection.Query<MemberGetList>("MI_GetList_Member_Search", parameters, null, true, null, CommandType.StoredProcedure).AsList<MemberGetList>()
                    );
                    int totalRecords = parameters.Get<int>("TotalRecords");
                    return new MemberGetListResponse
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
                return new MemberGetListResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
