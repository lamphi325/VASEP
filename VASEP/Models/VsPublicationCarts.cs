using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VsPublicationCarts
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? PubId { get; set; }
        public int? PubValueId { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string AddressExport { get; set; }
        public string AddressImport { get; set; }
        public string Mst { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public byte? PaymentType { get; set; }
        public byte? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatetedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public byte? PortalId { get; set; }
    }
}
