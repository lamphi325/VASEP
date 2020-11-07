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
using VASEP.Interfaces.Models.Home;

namespace VASEP.Implement
{
    public class HomeBusinessLogic : IHomeBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public HomeBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<BaiMoiDanhMucResponse> BaiMoiDanhMuc(BaiMoiDanhMucRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<NewDetail> lstData = new List<NewDetail>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("subtractIds", request.SubtractIds);
                    parameters.Add("CategoryId", request.CategoryId);
                    parameters.Add("portalId", request.PortalId);
                    parameters.Add("count", request.Count);
                    parameters.Add("isImage", request.IsImage);

                    await Task.Run(() =>
                        lstData = connection.Query<NewDetail>("News_News_Show_BaiMoiDanhMuc", parameters, null, true, null, CommandType.StoredProcedure).AsList<NewDetail>()
                    );
                    return new BaiMoiDanhMucResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        LstData = lstData,
                    };
                }
            }
            catch (Exception ex)
            {
                return new BaiMoiDanhMucResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<BaiMoiNhatResponse> BaiMoiNhat(BaiMoiNhatRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<NewDetail> lstData = new List<NewDetail>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@portalid", request.PortalId);
                    parameters.Add("@Count", request.Count);

                    await Task.Run(() =>
                        lstData = connection.Query<NewDetail>("News_News_Show_BaiMoiNhat", parameters, null, true, null, CommandType.StoredProcedure).AsList<NewDetail>()
                    );
                    return new BaiMoiNhatResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        LstData = lstData,
                    };
                }
            }
            catch (Exception ex)
            {
                return new BaiMoiNhatResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<NewDetailResponse> NewDetail(NewDetailRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    NewDetail newDetail = new NewDetail();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@newid", request.NewId);
                    parameters.Add("@portalid", request.PortalId);

                    await Task.Run(() =>
                        newDetail = connection.Query<NewDetail>("News_News_selectbyid", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );
                    return new NewDetailResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        New = newDetail,
                    };
                }
            }
            catch (Exception ex)
            {
                return new NewDetailResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
