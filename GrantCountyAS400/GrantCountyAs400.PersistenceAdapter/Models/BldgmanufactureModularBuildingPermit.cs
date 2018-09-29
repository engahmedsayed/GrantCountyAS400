using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class BldgmanufactureModularBuildingPermit
    {
        public int Id { get; set; }
        public string RecordStatus { get; set; }
        public string JurisdictionCode { get; set; }
        public string DepartmentCode { get; set; }
        public decimal? ApplicationYear { get; set; }
        public decimal? ApplicationNumber { get; set; }
        public decimal? AddendumNumber { get; set; }
        public string OfficeProjectDescription { get; set; }
        public string ManorMod { get; set; }
        public string BuildingDescription { get; set; }
        public decimal? YearManufactured { get; set; }
        public string NewOrUsed { get; set; }
        public decimal? SquareFeet { get; set; }
        public string Dimensions { get; set; }
        public string ResCommStor { get; set; }
        public string CommercialUseDesc1 { get; set; }
        public string CommercialUseDesc2 { get; set; }
        public string DealerNameCode { get; set; }
        public string ManufacturerName { get; set; }
        public string LotorMan { get; set; }
        public DateTime? ApproxPurchaseDate { get; set; }
        public DateTime? ApproxDeliveryDate { get; set; }
        public string InstallationIncludedInPrice { get; set; }
        public string MovingFromGrantCounty { get; set; }
        public string CountyStateIfNotGrant { get; set; }
        public string TitleOwnerName { get; set; }
        public string TaxpayerName { get; set; }
        public decimal? MovingFromParcelNumber { get; set; }
        public string MovingFromAddress { get; set; }
        public string CertInstallerCode { get; set; }
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
