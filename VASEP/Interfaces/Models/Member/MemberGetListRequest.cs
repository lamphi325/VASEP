using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Member
{
    public class MemberGetListRequest
    {
        [MaxLength(255)]
        public string Keyword { get; set; }

        /// <summary>
        /// 0 tất cả
        /// 1 tên doanh nghiệp
        /// 2 tên thương mại
        /// 3 tỉnh/tp
        /// 4 eu code
        /// 5 chứng chỉ
        /// </summary>
        public int SearchType { get; set; } = 0;

        [Required]
        public int PageIndex { get; set; } = 1;

        [Required]
        public int PageSize { get; set; } = 20;
    }
}
