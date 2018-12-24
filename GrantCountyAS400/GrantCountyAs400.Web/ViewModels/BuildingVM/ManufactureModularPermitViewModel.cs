using System;
using System.ComponentModel.DataAnnotations;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class ManufactureModularPermitViewModel
    {
        [Display(Name = "Office Project Description")]
        public string OfficeProjectDescription { get; set; }

        [Display(Name = "Manuf or Mod(MAN/MOD)?")]
        public string ManorMod { get; set; }

        [Display(Name = "Year Manufactured")]
        public int YearManufactured { get; set; }

        [Display(Name = "New/Used (N/U)?")]
        public string NewOrUsed { get; set; }

        [Display(Name = "Square Feet")]
        public decimal SquareFeet { get; set; }

        [Display(Name = "Dimensions")]
        public string Dimensions { get; set; }

        [Display(Name = "Description")]
        public string BuildingDescription { get; set; }

        [Display(Name = "Primary Use(R=Res, S=Stor, C=Comm)")]
        public string ResCommStor { get; set; }

        public string CommercialUseDesc1 { get; set; }
        public string CommercialUseDesc2 { get; set; }
        public string DealerNameCode { get; set; }
        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }
        [Display(Name = "From Lot or Manf?")]
        public string LotorMan { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Purchase Date")]
        public DateTime? ApproxPurchaseDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Delivery Date")]
        public DateTime? ApproxDeliveryDate { get; set; }
        [Display(Name = "Installation Included?")]
        public string InstallationIncludedInPrice { get; set; }
        [Display(Name = "Move From GrantCounty?")]
        public string MovingFromGrantCounty { get; set; }
        [Display(Name = "Other County or State")]
        public string CountyStateIfNotGrant { get; set; }
        [Display(Name = "Current Title Owner")]
        public string TitleOwnerName { get; set; }
        [Display(Name = "Current Taxpayer name")]
        public string TaxpayerName { get; set; }
        [Display(Name = "From Parcel")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal MovingFromParcelNumber { get; set; }
        [Display(Name = "From Address")]
        public string MovingFromAddress { get; set; }
        public string CertInstallerCode { get; set; }
        public string FireDistrictCode { get; set; }
        public string FireFlowAlreadyProvided { get; set; }
        public string AdditionalFireFlowRequired { get; set; }
        public string AmountOfFireFlowRequired { get; set; }
        [Display(Name = "Building Setback")]
        public decimal BldgDeptSetback { get; set; }
        [Display(Name = "Fire Marshal Setback ")]
        public decimal FireMarshalSetback { get; set; }
        [Display(Name = "Total Valuation")]
        public decimal ExtendedValue { get; set; }
        public string LongFireDistrictName { get; set; }
        public bool HasBuildingApplicationCondition { get; set; }
        public bool HasBuildingApplicationInspection { get; set; }
        public DealersInstallersArchitectInfoViewModel DealerInfo { get; set; }
        public DealersInstallersArchitectInfoViewModel InstallerInfo { get; set; }
        public PermitApprovedInfoViewModel BldgDept { get; set; }
        public PermitApprovedInfoViewModel FireMarshal { get; set; }

        public bool ShowCommercialUse => (ResCommStor.ToLower() == "c");
        public string CommercialUseDescDisplay => $"{CommercialUseDesc1} {CommercialUseDesc2}";
        [Display(Name = "Fire District")]
        public string FireDistrictDisplay => $"{FireDistrictCode} - {LongFireDistrictName}";
        public string ConditionsExist => (HasBuildingApplicationCondition) ? "Conditions Exist" : string.Empty;
        public string InspectionsExist => (HasBuildingApplicationInspection) ? "Inspections Exist" : string.Empty;
    }
}