using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgotherPermitDetail
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string OfficeProjectDescription { get; set; }
        public string AdditionalInformationDescription { get; set; }
        public string FireDistrictCode { get; set; }
        public string FireFlowAlreadyProvided { get; set; }
        public string AdditionalFireFlowRequired { get; set; }
        public string AmountOffireFlowRequired { get; set; }
        public string BldgDeptApprovedBy { get; set; }
        public DateTime? BldgDeptDateApproved { get; set; }
        public string BldgDeptApprovedUserId { get; set; }
        public DateTime? BldgDeptApprovedChangeDate { get; set; }
        public string FireMarshalApprovedBy { get; set; }
        public DateTime? FireMarshalDateApproved { get; set; }
        public string FireMarshalApprovedUserId { get; set; }
        public DateTime? FireMarshalApprovedChangeDate { get; set; }
        public decimal? BldgDeptSetback { get; set; }
        public decimal? FireMarshalSetback { get; set; }
    }
}
