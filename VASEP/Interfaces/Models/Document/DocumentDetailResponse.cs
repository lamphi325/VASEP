using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Document
{
    public class DocumentDetailResponse : BaseResponse<ResponseStatus>
    {
        public DocumentDetail Document { get; set; }
    }

    public class DocumentDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Quote { get; set; }
        public string Description { get; set; }
        public int ViewCount { get; set; }
        public string CategoryIds { get; set; }
        public string CategoryName { get; set; }
        public string Field { get; set; }
        public string FieldName { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string PublishedName { get; set; }
        public int Type { get; set; }
        public DateTime? ValidedDate { get; set; }
        public List<DocsFile> DocsFiles { get; set; }
    }
}
