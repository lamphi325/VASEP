using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Mi
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
        public string CompanyName { get; set; }
        public string TradeNames { get; set; }
        public string Field { get; set; }
        public string TypeOfBusiness { get; set; }
        public int? MemberType { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Nationnality { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string LanguageId { get; set; }
        public string TypeId { get; set; }
        public string Recommender { get; set; }
        public string ProfileUrl { get; set; }
        public string AvatarUrl { get; set; }
        public long? VerifyCode { get; set; }
        public bool? IsVerified { get; set; }
        public int? IdCareers { get; set; }
        public string Products { get; set; }
        public string Description { get; set; }
        public string Quality { get; set; }
        public string Eucode { get; set; }
        public string ScopeOfWork { get; set; }
        public string ExportMarket { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
