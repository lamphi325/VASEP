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
using VASEP.Interfaces.Models.Document;
using VASEP.Models;

namespace VASEP.Implement
{
    public class DocumentBusinessLogic : IDocumentBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public DocumentBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<DocumentDetailResponse> DocumentDetail(DocumentDetailRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    DocumentDetail document = new DocumentDetail();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Id", request.Id);

                    await Task.Run(() =>
                        document = connection.Query<DocumentDetail>("App_Docs_Get", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );

                    if (document != null)
                    {
                        parameters = new DynamicParameters();
                        parameters.Add("@DocId", document.Id);
                        await Task.Run(() =>
                            document.DocsFiles = connection.Query<DocsFile>("DocsFiles_GetByDocId", parameters, null, true, null, CommandType.StoredProcedure).AsList<DocsFile>()
                        );
                    }
                    return new DocumentDetailResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        Document = document,
                    };
                }
            }
            catch (Exception ex)
            {
                return new DocumentDetailResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<DocumentGetListResponse> GetList(DocumentGetListRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    List<DocumentGetList> lstData = new List<DocumentGetList>();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Name", request.Name ?? "");
                    parameters.Add("@Code", request.Code ?? "");
                    parameters.Add("@CategoryIds", request.CategoryIds ?? "0");
                    parameters.Add("@IsPublish", request.IsPublish);
                    parameters.Add("@IssuedDate", request.IssuedDate ?? "");
                    parameters.Add("@CreatedUser", request.CreatedUser);
                    parameters.Add("@Field", request.Field);
                    parameters.Add("@Source", request.Source);
                    parameters.Add("@Type", request.Type);
                    parameters.Add("@PortalId", request.PortalId);
                    parameters.Add("@LanguageId", request.Language);
                    parameters.Add("@PageSize", request.PageSize);
                    parameters.Add("@PageIndex", request.PageIndex);
                    parameters.Add("@Status", request.Status);
                    parameters.Add("@IsRole", request.IsRole ?? "-1");

                    await Task.Run(() =>
                        lstData = connection.Query<DocumentGetList>("Docs_SearchAdvance", parameters, null, true, null, CommandType.StoredProcedure).AsList<DocumentGetList>()
                    );
                    int totalRecords = lstData.Count > 0 ? lstData[0].TotalRecords : 0;

                    if (lstData != null)
                    {
                        foreach (var item in lstData)
                        {
                            parameters = new DynamicParameters();
                            parameters.Add("@DocId", item.Id);
                            await Task.Run(() =>
                                item.DocsFiles = connection.Query<DocsFile>("DocsFiles_GetByDocId", parameters, null, true, null, CommandType.StoredProcedure).AsList<DocsFile>()
                            );
                        }
                    }
                    return new DocumentGetListResponse
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
                return new DocumentGetListResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        public async Task<UpdateViewCountResponse> UpdateViewCount(GetByIdRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    Docs docs = new Docs();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Id", request.Id);

                    await Task.Run(() =>
                        docs = connection.Query<Docs>("Docs_Get", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );

                    if (docs != null)
                    {
                        parameters = new DynamicParameters();
                        parameters.Add("@Id", docs.Id);
                        parameters.Add("@Code", docs.Code);
                        parameters.Add("@Name", docs.Name);
                        parameters.Add("@Quote", docs.Quote);
                        parameters.Add("@Description", docs.Description);
                        parameters.Add("@Keyword", docs.Keyword);
                        parameters.Add("@ViewCount", docs.ViewCount + 1);
                        parameters.Add("@LikeCount", docs.LikeCount);
                        parameters.Add("@DislikeCount", docs.DislikeCount);
                        parameters.Add("@DownloadCount", docs.DownloadCount);
                        parameters.Add("@CommentCount", docs.CommentCount);
                        parameters.Add("@CategoryIds", docs.CategoryIds);
                        parameters.Add("@Field", docs.Field);
                        parameters.Add("@Source", docs.Source);
                        parameters.Add("@Signer", docs.Signer);
                        parameters.Add("@CreatedDate", docs.CreatedDate);
                        parameters.Add("@CreatedUser", docs.CreatedUser);
                        parameters.Add("@UpdatedDate", docs.UpdatedDate);
                        parameters.Add("@UpdatedUser", docs.UpdatedUser);
                        parameters.Add("@PublishedDate", docs.PublishedDate);
                        parameters.Add("@PublishedUser", docs.PublishedUser);
                        parameters.Add("@IssuedDate", docs.IssuedDate);
                        parameters.Add("@ValidedDate", docs.ValidedDate);
                        parameters.Add("@IsPublish", docs.IsPublish);
                        parameters.Add("@IsDownload", docs.IsDownload);
                        parameters.Add("@Type", docs.Type);
                        parameters.Add("@Status", docs.Status);
                        parameters.Add("@PortalId", docs.PortalId);
                        parameters.Add("@LanguageId", docs.LanguageId);
                        await Task.Run(() =>
                            connection.Query("Docs_Update", parameters, null, true, null, CommandType.StoredProcedure)
                        );
                        return new UpdateViewCountResponse
                        {
                            Status = ResponseStatus.Success,
                            Message = ResponseStatus.Success.ToString(),
                        };
                    }
                    return new UpdateViewCountResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                    };
                }
            }
            catch (Exception ex)
            {
                return new UpdateViewCountResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
