using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgstructureBuildingPermitDetail
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string OfficeProjectDescription { get; set; }
        public string ResAgCommOther { get; set; }
        public decimal? NumberOfBedrooms { get; set; }
        public decimal? NumberOfBathrooms { get; set; }
        public decimal? NumberOfUnits { get; set; }
        public string Heated { get; set; }
        public string HeatSourceDescription { get; set; }
        public string PrescriptiveReviewDone { get; set; }
        public string WattsunRunReviewDone { get; set; }
        public string Nrecreceived { get; set; }
        public string PlansAnalystReviewDone { get; set; }
        public string PlansAnalystReviewDescription { get; set; }
        public string SprinklerSystemRequired { get; set; }
        public string SprinklerSystemDescription { get; set; }
        public string AlarmSystemRequired { get; set; }
        public string AlarmSystemDescription { get; set; }
        public string SpecialInspectionRequired { get; set; }
        public string SpecialInspectionDescription { get; set; }
        public string PermitIncludePlumbing { get; set; }
        public string PermitIncludeMechanical { get; set; }
        public string FireDistrictCode { get; set; }
        public string FireFlowAlreadyProvided { get; set; }
        public string AdditionalFireFlowRequired { get; set; }
        public string AmountOfFireFlowRequired { get; set; }
        public string BldgDeptApprovedBy { get; set; }
        public DateTime? BldgDepDateApproved { get; set; }
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
