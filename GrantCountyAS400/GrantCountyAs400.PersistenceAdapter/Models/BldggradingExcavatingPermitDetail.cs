using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldggradingExcavatingPermitDetail
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string OfficeProjectDescription { get; set; }
        public decimal? CubicYardsOfFill { get; set; }
        public decimal? PercentOfSlope { get; set; }
        public string SoilErosionControlRequired { get; set; }
        public string DustAndTrackControlReceived { get; set; }
        public DateTime? DustAndTrackReceivedDate { get; set; }
        public string EngineeringReceived { get; set; }
        public DateTime? EngineeringReceivedDate { get; set; }
        public string FireDistrictCode { get; set; }
        public string FireFlowAlreadyProvided { get; set; }
        public string AdditionalFireFlowRequired { get; set; }
        public string AmountOfFireFlowRequired { get; set; }
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
