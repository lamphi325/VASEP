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
using VASEP.Interfaces.Models.Media;

namespace VASEP.Implement
{
    public class MediaBusinessLogic : IMediaBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public MediaBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<VideoDetailResponse> VideoDetail(VideoDetailRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    VideoObject video = new VideoObject();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@id", request.Id);
                    parameters.Add("@portalid", request.PortalId);

                    await Task.Run(() =>
                        video = connection.Query<VideoObject>("Videos_SelectByID", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );
                    return new VideoDetailResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        Video = video,
                    };
                }
            }
            catch (Exception ex)
            {
                return new VideoDetailResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<VideoShowResponse> VideoGetList(VideoShowRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<VideoShow> lstData = new List<VideoShow>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@subtractIds", request.SubtractIds);
                    parameters.Add("@danhmuc", request.Danhmuc);
                    parameters.Add("@istruyenhinh", request.Istruyenhinh);
                    parameters.Add("@portalId", request.PortalId);
                    parameters.Add("@PageIndex", request.PageIndex);
                    parameters.Add("@PageSize", request.PageSize);
                    await Task.Run(() =>
                        lstData = connection.Query<VideoShow>("VideosShowfind_Index", parameters, null, true, null, CommandType.StoredProcedure).AsList<VideoShow>()
                    );
                    int totalRecords = lstData.Count > 0 ? lstData[0].TotalRecords : 0;
                    return new VideoShowResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        LstVideo = lstData,
                        TotalRecords = totalRecords,
                    };
                }
            }
            catch (Exception ex)
            {
                return new VideoShowResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
