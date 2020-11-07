using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Document
{
    public class DocumentGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<DocumentGetList> LstData { get; set; }
        public int TotalRecords { get; set; }
    }

    public class DocumentGetList
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Quote { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int TotalRecords { get; set; }
        public List<DocsFile> DocsFiles { get; set; }
    }

    public class DocsFile
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public bool Status { get; set; }
    }
}
