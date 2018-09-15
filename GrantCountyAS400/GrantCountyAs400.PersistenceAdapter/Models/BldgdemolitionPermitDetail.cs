using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgdemolitionPermitDetail
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string OfficeProjectDescription { get; set; }
        public decimal? SquareFeet { get; set; }
        public string Dimensions { get; set; }
        public string BuildingDescription { get; set; }
        public string RequiredHandoutsProvided { get; set; }
        public DateTime? DateProvided { get; set; }
        public string ToWhomProvided { get; set; }
        public string FireDistrictCode { get; set; }
        public string BldgDeptApprovalBy { get; set; }
        public DateTime? BldgDeptDateApproved { get; set; }
        public string BldgDeptApprovedUserId { get; set; }
        public DateTime? BldgDeptApprovedChangeDate { get; set; }
        public string FireMarshalApprovalBy { get; set; }
        public DateTime? FireMarshalDateApproved { get; set; }
        public string FireMarshalApprovedUserId { get; set; }
        public DateTime? FireMarshalApprovedChangeDate { get; set; }
        public decimal? BldgDeptSetback { get; set; }
        public decimal? FireMarshalSetback { get; set; }
    }
}
